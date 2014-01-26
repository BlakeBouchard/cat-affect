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
        if (other.gameObject.name == "Kitty")
        {
            //Plays a little splash. Added by Rebeca.
            if (flow.puddle_touch == false)
            {
                audio.Play();
            }

            flow.puddle_touch = true;
            flow.out_of_water_time = 0.0F;
            flow.up_water = 1;
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Kitty")
        {
            flow.puddle_touch = false;
            flow.out_of_water_time = Time.time;
        }
    }
}
