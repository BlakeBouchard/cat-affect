using UnityEngine;
using System.Collections;

public class Water_Puddle : MonoBehaviour {

    public bool puddle_in_use = false;
    public Transform Brick;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) { 
        if(!puddle_in_use){
            for (var y = 0; y < 5; y++)
            {
                for (var x = 0; x < 5; x++)
                {
                    Instantiate(Brick, new Vector3(x, y, 0), Quaternion.identity);
                }
            }
        }

    }
}
