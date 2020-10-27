using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayPresskeyH : MonoBehaviour
{

    public AudioSource cLong;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (!cLong.isPlaying)
            {
                cLong.Play();

            }
        }
        //if (Input.GetKeyUp(KeyCode.H))
        //{ cLong.Stop();
        //}

    }
}
