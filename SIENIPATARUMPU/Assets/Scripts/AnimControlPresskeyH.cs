using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlPresskeyH : MonoBehaviour
{
    public GameObject theNPC;

    void Update()
    {
        if (Input.GetButtonDown("HKey"))
        {
            theNPC.GetComponent<Animator>().Play("YDOT03_press");
        }
    }
}
