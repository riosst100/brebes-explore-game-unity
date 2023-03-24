using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("Menu Screens")]
    [SerializeField] private AdmobAdsManager adsManager;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private Image LoadingBarFill;

    void Start() 
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    public void MulaiGame() 
    {
        // adsManager.ShowRewardedInterstitialAd();
        // SceneManager.LoadScene("Playground");
        mainMenu.SetActive(false);

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

    public void Keluar() 
    {
        Application.Quit();
    }
}
