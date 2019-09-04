using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    float score;
    public float scoreDivider = 2f;
    public float LevelEndThreshold = 100f;
    public bool LevelEnd = false;

    // Update is called once per frame
    void LateUpdate()
    {
        score = player.position.z / scoreDivider;
        scoreText.text = score.ToString("0") + "m";

        if (score >= LevelEndThreshold)
        {
            FindObjectOfType<GameManager>().CompleteLevel();
        }
    }
}
