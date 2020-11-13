using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlPresskeyO : MonoBehaviour
{
    public GameObject ClickAnimation;

    void Update()
    {
        if (Input.GetButtonDown("OKey"))
        {
            ClickAnimation.GetComponent<Animator>().Play("YDOT02_press");
        }
    }
}
