using UnityEngine;
using System.Collections;

public class TitleButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnMouseDown()
    {
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePosition = new Vector2(worldPoint.x, worldPoint.y);

        if (Physics2D.OverlapPoint(mousePosition))
        {
            Debug.Log("Start Game");
            Application.LoadLevel("level1");
        }
    }

	// Update is called once per frame
	void Update () {
        
	}
}
