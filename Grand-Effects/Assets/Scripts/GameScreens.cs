using UnityEngine;
using System.Collections;

public class GameScreens : MonoBehaviour {

    bool isPaused = false;
    GameObject greenBackground;
    //GameObject wetBackground;
    //GameObject desertBackground;
    GameObject levelCompleteScreen;

	// Use this for initialization
	void Start () {
        greenBackground = GameObject.Find("Green Background");
        levelCompleteScreen = GameObject.Find("Level Complete");
	}

    public void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;
        isPaused = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                UnpauseGame();
            }
            else
            {
                PauseGame();
            }
        }

	}

    internal void levelComplete()
    {
		Debug.Log ("Level Complete!");
		levelCompleteScreen.transform.localScale = new Vector3(1, 1, 1);
        //PauseGame();
    }
}
