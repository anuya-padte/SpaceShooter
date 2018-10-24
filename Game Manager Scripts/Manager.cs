using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    bool gameHasEnded = false;
    public int  restartDelay=5;
    public GameObject completeLevelUI;

    //to end the game
    public void endGame() {
        if (!gameHasEnded)
        {
            Debug.Log("Game has ended");
            gameHasEnded = true;
            FindObjectOfType<score>().restartText();
       
                Invoke("restart", restartDelay);
        }
    }



     void restart() {
        //this is method 1 to restart, where MainGame is the name of the ongoing Scene itself!
        SceneManager.LoadScene("MainGame");
        //or:
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void levelComplete() {
        Debug.Log("We finished boi!");
        completeLevelUI.SetActive(true);
    }
}
