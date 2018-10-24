using UnityEngine;
using UnityEngine.SceneManagement;


public class GameEnds : MonoBehaviour
{

    public void LoadCredits()
    {
        SceneManager.LoadScene("FinalCredits!");
    }
}
