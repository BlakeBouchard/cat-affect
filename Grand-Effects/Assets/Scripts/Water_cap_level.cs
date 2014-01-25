using UnityEngine;
using System.Collections;

public class Water_cap_level : MonoBehaviour {

    public Water_flow water_flow;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "water")
        {
            water_flow.level_water_cap = false; 
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "water")
        {
            water_flow.level_water_cap = true; 
        }
    }
}
