using UnityEngine;
using System.Collections;

public class Water_flow : MonoBehaviour {

    private float y = 1;
    private float x = 1;
    private float water_rate = 0.5F;
    private float water = 0.0F;
    private bool right = true;
    private bool left = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Debug.Log(Time.time);
        if (Time.time > water)
        {
            
            water = Time.time + water_rate;
            if (right)
            {
                
                //x += 1.0F;
                transform.position += new Vector3(x, 0, 0);
                Debug.Log(transform.position);
                right = false;
                
            }

            else 
            {
                transform.position -= new Vector3(x, 0, 0);
                Debug.Log(transform.position);
                right = true;
                
            }

            transform.position += new Vector3(0, y, 0);
        }

            
            
            //y = y + 0.1;
    

	}
}
