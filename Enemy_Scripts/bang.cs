using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bang : MonoBehaviour {

    public GameObject gameObject;

    // Use this for initialization


    //for collision of two things:
    private void OnCollisionEnter(Collision information)
    {
            if (information.collider.tag == "Bullet"|| information.collider.tag == "Player")
            {   
            Invoke("Explode",0);
            }
    }

    void Explode()
    {
        
        Destroy(gameObject);
    }

}
