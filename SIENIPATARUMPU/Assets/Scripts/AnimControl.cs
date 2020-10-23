using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    public GameObject theNPC;

    // Update is called once per frame
    void Update()
    {
     if(Input.GetButtonDown("GKey"))
        {
            theNPC.GetComponent<Animator>().Play("Pallo_Y_tap01");
        }
    }
}
