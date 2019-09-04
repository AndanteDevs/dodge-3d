using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Rigidbody player;
    bool gameHasEnded = false;
    bool gameIsComplete = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    void Start ()
    {
        Debug.Log("Loaded " + SceneManager.GetActiveScene().name.ToString());
    }

    void Update ()
    {
        if ( Input.GetKey("r") )
        {
            RestartAll();
        }
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("Player death");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Restarted " + SceneManager.GetActiveScene().name.ToString());
    }
    
    void RestartAll ()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Restarted game");
    }

    public void CompleteLevel ()
    {
        if (gameIsComplete == false)
        {
            Debug.Log("Passed " + SceneManager.GetActiveScene().name.ToString());
            gameIsComplete = true;
            completeLevelUI.SetActive(true);
            player.isKinematic = true;
        }
    }

}
