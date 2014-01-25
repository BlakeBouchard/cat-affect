using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float pushForce = 5.0f;
    public float jumpForce = 10.0f;
    public float normalGravity = 9.81f;
    public float maxSpeed = 20.0f;

    public bool isSwimming = true;
    public float swimForce = 2.0f;
    public float swimJumpForce = 2.0f;
    public float swimGravity = 0.3f;
    public float swimMaxSpeed = 4.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (isSwimming)
        {

            //sets max velocity
            rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity, swimMaxSpeed);
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

            //sets max velocity
            rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity, maxSpeed);
            rigidbody2D.gravityScale = normalGravity;

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
