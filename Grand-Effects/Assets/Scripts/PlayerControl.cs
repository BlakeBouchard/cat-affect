using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float pushForce = 5.0f;
    public float jumpForce = 10.0f;

    public bool isSwimming = true;
    public float swimForce = 2.0f;
    public float swimJumpForce = 2.0f;
    public float swimGravity = 0.3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (isSwimming)
        {

            rigidbody2D.gravityScale = swimGravity;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rigidbody2D.AddForce(new Vector2(-swimForce, 0));
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rigidbody2D.AddForce(new Vector2(swimForce, 0));
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, swimJumpForce);
            }
        }
        else
        {

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rigidbody2D.AddForce(new Vector2(-pushForce, 0));
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rigidbody2D.AddForce(new Vector2(pushForce, 0));
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpForce);
            }
        }
	}
}
