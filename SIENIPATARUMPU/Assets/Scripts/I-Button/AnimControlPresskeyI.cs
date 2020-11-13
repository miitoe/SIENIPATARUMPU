using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlPresskeyI : MonoBehaviour
{
    public GameObject ClickAnimation;

    void Update()
    {
        if (Input.GetButtonDown("IKey"))
        {
            ClickAnimation.GetComponent<Animator>().Play("YDOT01_press");
        }
    }
}
