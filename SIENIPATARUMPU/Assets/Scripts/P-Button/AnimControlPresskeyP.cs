using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlPresskeyP : MonoBehaviour
{
    public GameObject ClickAnimation;

    void Update()
    {
        if (Input.GetButtonDown("PKey"))
        {
            ClickAnimation.GetComponent<Animator>().Play("YDOT03_press");
        }
    }
}