using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class score : MonoBehaviour {
    public Rigidbody playerwa;
    public bool fallen=false;
    public Transform player;
    public Text scorewa;//we will put the score in here
    public float finalPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	    void Update () {
        scorewa.text=player.position.z.ToString("0");

        //it has stopped moving in the y direction so end game
        if (playerwa.velocity.magnitude==0||fallen) {
            scorewa.text = "Lol. Gaem Over";
            FindObjectOfType<Manager>().endGame();
            restartText();
            finalPos = player.position.z;
        }


	}

    public void restartText() {
        scorewa.text = "Final Score is "+ finalPos+"Press X to end game!";

        if (Input.GetKey("x")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
