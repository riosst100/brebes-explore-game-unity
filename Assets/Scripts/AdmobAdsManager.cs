using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// using GoogleMobileAds.Api;
// using GoogleMobileAds.Common;
using System;
using System.Collections.Generic;

public class AdmobAdsManager : MonoBehaviour
{
    // private RewardedInterstitialAd rewardedInterstitialAd;
    // public UnityEvent OnAdLoadedEvent;
    // public UnityEvent OnAdFailedToLoadEvent;
    // public UnityEvent OnAdOpeningEvent;
    // public UnityEvent OnAdFailedToShowEvent;
    // public UnityEvent OnUserEarnedRewardEvent;
    // public UnityEvent OnAdClosedEvent;

    // [Header("Admob Ads ID")]
    // [SerializeField] string rewaredInterstitialAd_ID;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     // MobileAds.Initialize(HandleInitCompleteAction);

    //     // RequestAndLoadRewardedInterstitialAd();
    // }

    // private void HandleInitCompleteAction(InitializationStatus initstatus)
    // {
    //     Debug.Log("Initialization complete.");
    // }

    // #region HELPER METHODS

    // private AdRequest CreateAdRequest()
    // {
    //     // return new AdRequest.Builder()
    //     //     .AddKeyword("unity-admob-sample")
    //     //     .Build();
    // }

    // #endregion

    // private void RequestAndLoadRewardedInterstitialAd()
    // {
    //     string adUnitId = rewaredInterstitialAd_ID;
        
    //     Debug.Log("Requesting Rewarded Interstitial ad.");

    //     // Create a rewarded interstitial.
    //     RewardedInterstitialAd.Load(adUnitId, CreateAdRequest(),
    //         (RewardedInterstitialAd ad, LoadAdError loadError) =>
    //         {
    //             if (loadError != null)
    //             {
    //                 Debug.Log("Rewarded intersitial ad failed to load with error: " +
    //                             loadError.GetMessage());
    //                 return;
    //             }
    //             else if (ad == null)
    //             {
    //                 Debug.Log("Rewarded intersitial ad failed to load.");
    //                 return;
    //             }

    //             Debug.Log("Rewarded interstitial ad loaded.");
    //             rewardedInterstitialAd = ad;

    //             ad.OnAdFullScreenContentOpened += () =>
    //             {
    //                 Debug.Log("Rewarded intersitial ad opening.");
    //                 OnAdOpeningEvent.Invoke();
    //             };
    //             ad.OnAdFullScreenContentClosed += () =>
    //             {
    //                 Debug.Log("Rewarded intersitial ad closed.");
    //                 OnAdClosedEvent.Invoke();
    //             };
    //             ad.OnAdImpressionRecorded += () =>
    //             {
    //                 Debug.Log("Rewarded intersitial ad recorded an impression.");
    //             };
    //             ad.OnAdClicked += () =>
    //             {
    //                 Debug.Log("Rewarded intersitial ad recorded a click.");
    //             };
    //             ad.OnAdFullScreenContentFailed += (AdError error) =>
    //             {
    //                 Debug.Log("Rewarded intersitial ad failed to show with error: " +
    //                             error.GetMessage());
    //             };
    //             ad.OnAdPaid += (AdValue adValue) =>
    //             {
    //                 string msg = string.Format("{0} (currency: {1}, value: {2}",
    //                                             "Rewarded intersitial ad received a paid event.",
    //                                             adValue.CurrencyCode,
    //                                             adValue.Value);
    //                 Debug.Log(msg);
    //             };
    //         });
    // }

    // public void ShowRewardedInterstitialAd() 
    // {
    //     if (rewardedInterstitialAd != null)
    //     {
    //         rewardedInterstitialAd.Show((Reward reward) =>
    //         {
    //             Debug.Log("Rewarded interstitial granded a reward: " + reward.Amount);

    //             OnUserEarnedRewardEvent.Invoke();
    //         });
    //     }
    //     else
    //     {
    //         Debug.Log("Rewarded Interstitial ad is not ready yet.");
    //     }
    // }
}
