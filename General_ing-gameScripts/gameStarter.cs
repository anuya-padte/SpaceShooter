using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameStarter : MonoBehaviour {

    // Use this for initialization
    public void Starter() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
