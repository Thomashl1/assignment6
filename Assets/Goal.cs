using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D ()
	{
		Debug.Log("YOU WON!");
        ScoreScript.scoreValue += 100;
		Score.CurrentScore += 100;
        Score3Text.scoreValue2 += 100;
        if (ScoreScript.scoreValue % 500 == 0)
        {
            LevelScript.levelValue += 1;
        }
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
