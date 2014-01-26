using UnityEngine;
using System.Collections;

public class Water_flow : MonoBehaviour {

    private float y = 1;
    private float x = 1;
    private float water_rate = 0.5F;
    private float water = 0.0F;
    private float down_water = 0.0F;
    private bool right = true;

    //private float up_water_rate = 0.5F;
    public float up_water = 0.0F;

    public bool puddle_touch = false;
    
    public float out_of_water_time = 0.0F;

    public bool level_water_cap = true;

    public PlayerControl player;
    public Water_cap_level water_cap;
    public Wood_board_float wood;
    public Wood_board_float_vert wood2;
    //public GameObject wood_platform1;
    //public GameObject wood_platform2;

    private bool in_water;
    public double water_level;

	
    // Use this for initialization
	
    void Start () {
        player = GameObject.Find("Kitty").GetComponent<PlayerControl>();
        water_cap = GameObject.Find("pipe").GetComponent<Water_cap_level>();
        //if (gameObject.Find("wood_platform1")
        //{
            wood = GameObject.Find("wood_platform1").GetComponent<Wood_board_float>();
        //}
        //if (wood_platform2)
        //{
            wood2 = GameObject.Find("wood_platform2").GetComponent<Wood_board_float_vert>();
        //}
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("enter");
        if (other.gameObject.name == "Kitty")
        {
            //Debug.Log("kitty");    
            player.SwitchToSwim();
            in_water = true;
            out_of_water_time = 0.0F;
            up_water = 1;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.name == "Kitty")
        {
            //Debug.Log("GIT");
            player.SwitchToWalk();
            in_water = false;
            out_of_water_time = Time.time;
        }
    }
	
	// Update is called once per frame
	void Update () {
        water_level = transform.position.y;
        if(transform.position.y >= water_cap.cap)
        {
        level_water_cap = false;
        //wood.check2 = 0;
        wood2.check5 = 0;
        wood.down = false;
            
        }
        
        if ((!in_water) &&(!puddle_touch))
        //if (!puddle_touch )
        {
            //if (transform.position.y >= -8.551)
            //{
                
                
                if (Time.time > down_water)
                {
                    
                    down_water = Time.time + water_rate;
                    
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


                    //Debug.Log(Time.time);
                    //Debug.Log(up_water);
                    
                    //if ((Time.time) >= 10)
                    if(up_water >= 10)
                    {
                        if (transform.position.y <= -8.551)
                        {
                            up_water = 0;
                        }
                        //Debug.Log("Here");
                        //Debug.Log(Time.time);
                        //Debug.Log(out_of_water_time);
                        //puddle_touch = false;
                        transform.position -= new Vector3(0, y, 0);
                        level_water_cap = true;
                        wood.check2 = 1;
                        wood2.check5 = 1;
                        wood.down = true;

                    
                    }
                    up_water += 1;
                }
            //}
        }
        
        if (puddle_touch|| in_water)
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
