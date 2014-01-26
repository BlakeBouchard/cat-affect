using UnityEngine;
using System.Collections;

public class Water_cap_level : MonoBehaviour {

    public double cap; 
	// Use this for initialization
	void Start () {
        cap = transform.position.y - 2.5;
        //Debug.Log(cap);
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(cap);
	}



}
