using UnityEngine;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;
		public bool setting;
		public bool leave;

		[Header("Movement Settings")]
		public bool analogMovement;

		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
		public void OnMove(InputValue value)
		{
			MoveInput(value.Get<Vector2>());
		}

		public void OnLook(InputValue value)
		{
			if(cursorInputForLook)
			{
				LookInput(value.Get<Vector2>());
			}
		}

		public void OnJump(InputValue value)
		{
			JumpInput(value.isPressed);
		}

		public void OnSprint(InputValue value)
		{
			SprintInput(value.isPressed);
		}

		public void OnSetting(InputValue value)
		{
			SettingInput(value.isPressed);
		}

		public void OnLeave(InputValue value)
		{
			LeaveInput(value.isPressed);
		}
#endif
	
	public bool supportInputManager = true;

	public KeyCode jumpKey = KeyCode.Space;
	public KeyCode sprintKey = KeyCode.LeftShift;
	public KeyCode settingKey = KeyCode.Tab;
	public KeyCode leaveKey = KeyCode.Backspace;
	public float horzLookSensitivity = 100.0f;
	public float vertLookSensitivity = 100.0f;


	private void Update()
		{
		if (!this.supportInputManager)
			return;

		#if UNITY_EDITOR
		horzLookSensitivity = 5;
		vertLookSensitivity = 5;
		#endif

		this.MoveInput(new Vector2(ControlFreak2.CF2Input.GetAxis("Horizontal"), ControlFreak2.CF2Input.GetAxis("Vertical")));
		this.LookInput(new Vector2(
			ControlFreak2.CF2Input.GetAxis("Mouse X") * this.horzLookSensitivity, 
			ControlFreak2.CF2Input.GetAxis("Mouse Y") * this.vertLookSensitivity));
		this.JumpInput(ControlFreak2.CF2Input.GetKey(this.jumpKey));
		this.SprintInput(ControlFreak2.CF2Input.GetKey(this.sprintKey));
		this.SettingInput(ControlFreak2.CF2Input.GetKey(this.settingKey));
		this.LeaveInput(ControlFreak2.CF2Input.GetKey(this.leaveKey));
		}



		public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;
		} 

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}

		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}

		public void SettingInput(bool newSettingState)
		{
			setting = newSettingState;
		}

		public void LeaveInput(bool newLeaveState)
		{
			leave = newLeaveState;
		}

		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			ControlFreak2.CFCursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}
	}
	
}