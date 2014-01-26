using UnityEngine;
using System.Collections;

public class CameraOverlays : MonoBehaviour {

    bool isPaused = false;
    GameObject greenBackground;
    //GameObject wetBackground;
    //GameObject desertBackground;
    GameObject levelComplete;



	// Use this for initialization
	void Start () {
        greenBackground = GameObject.Find("Green Background");
        levelComplete = GameObject.Find("Level Complete");
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
}
