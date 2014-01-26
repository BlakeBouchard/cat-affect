using UnityEngine;
using System.Collections;

public class CreditsButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnMouseDown()
    {
        Debug.Log("Load Credits");
        Application.LoadLevel(Application.levelCount - 1);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
