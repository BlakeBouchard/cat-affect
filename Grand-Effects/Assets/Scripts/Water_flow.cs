using UnityEngine;
using System.Collections;

public class Water_flow : MonoBehaviour {

    private float y = 1;
    private float x = 1;
    private float water_rate = 0.5F;
    private float water = 0.0F;
    private bool right = true;
    
    public bool puddle_touch = false;
    
    private float out_of_water_time = 0.0F;

    public bool level_water_cap = true;

    public PlayerControl player;
    private bool in_water;
	
    // Use this for initialization
	
    void Start () {
        
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Kitty")
        {
            player.SwitchToSwim();
            in_water = true;
            out_of_water_time = 0.0F;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.name == "Kitty")
        {
            player.SwitchToWalk();
            in_water = false;
            out_of_water_time = Time.time;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y >= 0)
        {
        level_water_cap = false;
        }
        /*
        if (!in_water)
        {
            if ((Time.time - out_of_water_time) >= 10)
            {
                puddle_touch = false;
                transform.position -= new Vector3(0, y, 0);
            }
        }
        */
        if (puddle_touch)
        {
            //Debug.Log(Time.time);
            if (Time.time > water)
            {
                water = Time.time + water_rate;
                if (right)
                {
                    transform.position += new Vector3(x, 0, 0);
                    //Debug.Log(transform.position);
                    right = false;
                }
                else
                {
                    transform.position -= new Vector3(x, 0, 0);
                    //Debug.Log(transform.position);
                    right = true;
                }

                if (level_water_cap)
                {
                    //Debug.Log("level_water_cap");
                    transform.position += new Vector3(0, y, 0);
                }
            }        

        }
	}
}
