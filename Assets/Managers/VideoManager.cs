using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoManager : MonoBehaviour {

	public static VideoManager _VM;

    private void Start()
    {
        if(_VM == null)
        {
            _VM = this;
        }
        else
        {
            DestroyImmediate(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
