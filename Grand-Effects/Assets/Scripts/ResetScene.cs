using UnityEngine;
using System.Collections;

public class ResetScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnMouseDown()
    {
        Debug.Log("Reload level");
        Application.LoadLevel(Application.loadedLevel);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
