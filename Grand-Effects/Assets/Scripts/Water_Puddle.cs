using UnityEngine;
using System.Collections;

public class Water_Puddle : MonoBehaviour {

    public Water_flow flow;
	// Use this for initialization
	void Start () {
        flow = GameObject.Find("water").GetComponent<Water_flow>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        flow.puddle_touch = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // flow.puddle_touch = false;
    }
}
