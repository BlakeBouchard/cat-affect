using UnityEngine;
using System.Collections;

public class NextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}

    void OnMouseDown()
    {
        Debug.Log("Clicked Next Arrow");
        if (Application.loadedLevel < Application.levelCount - 1)
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
        else
        {
            Debug.Log("No more levels after this one");
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
