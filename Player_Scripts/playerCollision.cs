using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour {

    public newScript scriptToDisable;

    //for collision of two things:
    private void OnCollisionEnter(Collision information)  
    {
        if (information.collider.tag == "obstacles") {
            scriptToDisable.enabled = false;
        }
    }
}
