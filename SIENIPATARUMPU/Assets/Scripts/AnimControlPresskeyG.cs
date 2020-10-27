using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlPresskeyG : MonoBehaviour
{
    public GameObject theNPC;

    void Update()
    {
     if(Input.GetButtonDown("GKey"))
        {
            theNPC.GetComponent<Animator>().Play("Pallo_Y_tap01");
        }
    }
}
