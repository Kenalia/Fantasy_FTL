using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCallOnClick : MonoBehaviour {

	public void ButtonChangeScene(string sceneName)
    {
        GameManager._GM.LoadScene(sceneName);
    }
}
