using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager _GM;

    private void Start()
    {
        if (_GM == null)
        {
            _GM = this;
        }
        else
        {
            DestroyImmediate(this);
        }

        DontDestroyOnLoad(this);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public bool SaveScene(string sceneName)
    {

        // Implement start of saving protocol

        return false;
    }
}
