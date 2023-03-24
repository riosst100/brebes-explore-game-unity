// using GooglePlayGames;
// using GooglePlayGames.BasicApi;
// using GooglePlayGames.BasicApi.SavedGame;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManagement : MonoBehaviour
{
    [SerializeField] private GameObject privacyPolicyPopup;
    [SerializeField] private GameObject userAgreementPopup;
    // [SerializeField] private TextMeshProUGUI statusText;
    [Header("Screens")]
    // [SerializeField] private AdmobAdsManager adsManager;
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private Image LoadingBarFill;

    // private bool mStandby = false;

    // void Start() 
    // {
    //     PlayGamesPlatform.DebugLogEnabled = true;
    //     PlayGamesPlatform.Activate();
    //     PlayGamesPlatform.Instance.Authenticate(OnSignInResult);
    // }

    // public void playGamesLogin() 
    // {
    //     PlayGamesPlatform.DebugLogEnabled = true;
    //     PlayGamesPlatform.Activate();
    //     PlayGamesPlatform.Instance.Authenticate(OnSignInResult);
    // }

    // private void OnSignInResult(SignInStatus signInStatus)
    // {
    //     // EndStandBy();
    //     if (signInStatus == SignInStatus.Success)
    //     {
    //         statusText.text = "Authenticated. Hello, " + Social.localUser.userName + " (" + Social.localUser.id + ")";
    //     }
    //     else
    //     {
    //         statusText.text = "*** Failed to authenticate with " + signInStatus;
    //     }

    //     // ShowEffect(signInStatus == SignInStatus.Success);
    // }
    void Start() 
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    public void startGame() 
    {
        loadingScreen.SetActive(true);

        StartCoroutine(LoadSceneAsync("Playground"));
    }

    IEnumerator LoadSceneAsync(string sceneName) 
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(sceneName);

        while (!loadOperation.isDone) 
        {
            float progressValue = Mathf.Clamp01(loadOperation.progress / 0.9f);

            LoadingBarFill.fillAmount = progressValue;

            yield return null;
        }
    }

    public void exitGame() 
    {
        Application.Quit();
    }

    public void openPrivacyPolicyPopup() 
    {
        // Firebase.Analytics.FirebaseAnalytics
//   .LogEvent(Firebase.Analytics.FirebaseAnalytics.EventLogin);

        privacyPolicyPopup.SetActive(true);
    }

    public void closePrivacyPolicyPopup() 
    {
        privacyPolicyPopup.SetActive(false);
    }

    public void openUserAgreementPopup() 
    {
        // Firebase.Analytics.FirebaseAnalytics
//   .LogEvent(Firebase.Analytics.FirebaseAnalytics.EventLogin);

        userAgreementPopup.SetActive(true);
    }

    public void closeUserAgreementPopup() 
    {
        userAgreementPopup.SetActive(false);
    }
}
