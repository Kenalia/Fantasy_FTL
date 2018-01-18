using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

    public static PlayerPrefsManager _PPM;


    private void Start()
    {
        if (_PPM == null)
        {
            _PPM = this;
        }
        else
        {
            DestroyImmediate(this);
        }

        DontDestroyOnLoad(this);
    }

    public void SetKey(string key, int value)
    {
        PlayerPrefs.SetInt(key, value);
    }

    public void SetKey(string key, float value)
    {
        PlayerPrefs.SetFloat(key, value);
    }

    public void SetKey(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
    }

    public void SetKey(string key, bool value)
    {
        if(value)
        {
            PlayerPrefs.SetInt(key, 1);
        }
        else
        {
            PlayerPrefs.SetInt(key, 0);
        }
    }

    /// <summary>
    /// GetKey, but for ints
    /// </summary>
    /// <param name="key">PlayerPrefs key to get the value of</param>
    /// <param name="defaultValue">Value to place in key if key does not already exist</param>
    /// <returns>int</returns>
    public int GetKey(string key, int defaultValue = 0)
    {
        return PlayerPrefs.GetInt(key, defaultValue);
    }

    /// <summary>
    /// GetKey, but for floats
    /// </summary>
    /// <param name="key">PlayerPrefs key to get the value of</param>
    /// <param name="defaultValue">Value to place in key if key does not already exist</param>
    /// <returns>float</returns>
    public float GetKey(string key, float defaultValue = 0.0f)
    {
        return PlayerPrefs.GetFloat(key, defaultValue);
    }

    /// <summary>
    /// GetKey, but for strings
    /// </summary>
    /// <param name="key">PlayerPrefs key to get value of</param>
    /// <param name="defaultValue">Value to place in key if key does not already exist</param>
    /// <returns>float</returns>
    public string GetKey(string key, string defaultValue = " ")
    {
        return PlayerPrefs.GetString(key, defaultValue);
    }

    /// <summary>
    /// GetKey, but for bools
    /// </summary>
    /// <param name="key">PlayerPrefs key to get the value of</param>
    /// <returns>bool</returns>
    public bool GetKey(string key)
    {
        if(PlayerPrefs.GetInt(key) == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SavePrefs()
    {
        PlayerPrefs.Save();
    }

    //All possible prefs keys

    //Settings keys
    public string volumePrefsKey = "prefsKey_volume";
    public string fullscreenPrefsKey = "prefsKey_fullscreen";
    public string brightnessPrefsKey = "prefsKey_brightness";
}
