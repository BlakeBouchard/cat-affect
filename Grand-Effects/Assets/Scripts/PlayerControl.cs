using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float pushForce = 1.0f;
    public float jumpForce = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2D.AddForce(new Vector2(-pushForce, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2D.AddForce(new Vector2(pushForce, 0));
        }
        if (Input.GetKeyDown(KeyCode.Space) && rigidbody2D.velocity.y == 0)
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpForce);
        }
	}
}
