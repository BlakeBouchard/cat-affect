using UnityEngine;
using System.Collections;

public class ResetScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnMouseClick()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
