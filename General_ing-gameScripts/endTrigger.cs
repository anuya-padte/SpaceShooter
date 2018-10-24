using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour {

    public Manager mgr;

    private void OnTriggerEnter()
    {
        Debug.Log("Triggered End trigger");
        mgr.levelComplete();
    }
}
