using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    //animator variables
    //refrence for movement and animating: http://www.youtube.com/watch?v=Xnyb2f6Qqzg
    bool facingRight = true;
    Animator anim;

    public float pushForce = 5.0f;
    public float jumpForce = 10.0f;
    public float normalGravity;
    public float maxSpeed = 20.0f;

    public bool isSwimming = false;
    public float swimForce = 2.0f;
    public float swimJumpForce = 2.0f;
    public float swimGravity = 0.3f;
    public float swimMaxSpeed = 4.0f;

	// Use this for initialization
	void Start ()
    {
        //Animation Stuff
        anim = GetComponent<Animator>();

        normalGravity = rigidbody2D.gravityScale;
        SwitchToSwim();


	}

    void SwitchToSwim()
    {
        isSwimming = true;
        rigidbody2D.gravityScale = swimGravity;
    }

    void SwitchToWalk()
    {
        isSwimming = false;
        rigidbody2D.gravityScale = normalGravity;
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {


        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(move));

        if (isSwimming)
        {

            //sets max velocity
            rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity, swimMaxSpeed);

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

       
        //direction flipper
        if (move > 0 &&!facingRight)
        {
            Flip();
        }
        else if (move < 0 && facingRight)
        {
            Flip();
        }

	}
}
