using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsManager : MonoBehaviour {

    public static SettingsManager _SM;
    
    private Slider volumeSlider;
    private bool fullscreenValue;
    private Button fullscreenButton;
    private Slider brightnessSlider;

    private void Awake()
    {
        
    }

    private void Start()
    {
        if (_SM == null)
        {
            _SM = this;
        }
        else
        {
            DestroyImmediate(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        volumeSlider = GameObject.Find("volumeSlider").GetComponent<Slider>();
        brightnessSlider = GameObject.Find("brightnessSlider").GetComponent<Slider>();

        GameObject.Find("confirmSettingsBtn").GetComponent<Button>().onClick.AddListener(SaveSettings);

        volumeSlider.value = PlayerPrefsManager._PPM.GetKey(PlayerPrefsManager._PPM.volumePrefsKey, volumeSlider.maxValue / 2);

    }

    public void SaveSettings()
    {
        AudioListener.volume = volumeSlider.value;
        Screen.fullScreen = fullscreenValue;
        //Brightness when that gets figured out

        PlayerPrefsManager._PPM.SetKey(PlayerPrefsManager._PPM.volumePrefsKey, volumeSlider.value);
        PlayerPrefsManager._PPM.SetKey(PlayerPrefsManager._PPM.fullscreenPrefsKey, fullscreenValue);

        Debug.Log(PlayerPrefsManager._PPM.GetKey(PlayerPrefsManager._PPM.volumePrefsKey, 0.0f));
    }

    public void SetFullscreen(bool newSetting)
    {
        fullscreenValue = newSetting;
    }
}
