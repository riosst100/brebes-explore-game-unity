using System;
using System.Linq;
// using GooglePlayGames;
// using GooglePlayGames.BasicApi;
// using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine;
using TMPro;

public class LoginManagement : MonoBehaviour
{
    [SerializeField] private GameObject privacyPolicyPopup;
    [SerializeField] private GameObject userAgreementPopup;
    [SerializeField] private TextMeshProUGUI statusText;

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
