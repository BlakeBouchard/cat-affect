using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{

    //animator variables
    //refrence for movement and animating: http://www.youtube.com/watch?v=Xnyb2f6Qqzg
    bool facingRight = true;
    Animator anim;
    public Transform groundCheck;
    bool isGrounded = false;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;


    float lockPos = 0;


    public float pushForce = 10.0f;
    public float jumpForce = 700.0f;
    public float normalGravity;
    public float maxSpeed = 10f;

    public bool isSwimming = false;
    public float swimForce = 5.0f;
    public float swimJumpForce = 10.0f;
    public float swimGravity = 0.3f;
    public float swimMaxSpeed = 4.0f;

    // Use this for initialization
    void Start()
    {
        //Animation Stuff
        anim = GetComponent<Animator>();


        normalGravity = rigidbody2D.gravityScale;
        SwitchToWalk();

    }

    public void SwitchToSwim()
    {
        isSwimming = true;
        rigidbody2D.gravityScale = swimGravity;
        anim.SetBool("isSwimming", isSwimming);
    }

    public void SwitchToWalk()
    {
        isSwimming = false;
        rigidbody2D.gravityScale = normalGravity;
        anim.SetBool("isSwimming", isSwimming);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        anim.SetBool("isGrounded", isGrounded);

        anim.SetFloat("vSpeed", rigidbody2D.velocity.y);

        //kitty rotation lock
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, lockPos, lockPos);

        float move = Input.GetAxis("Horizontal");

        rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);

        //connects animator variables from animator controller
        anim.SetFloat("Speed", Mathf.Abs(move));
        
 

        //direction flipper
        if (move > 0 && !facingRight)
        {
            Flip();
        }
        else if (move < 0 && facingRight)
        {
            Flip();
        }

    }

    void Update()
    {
        anim.SetBool("isSwimming", isSwimming);

        /*
        if (isSwimming)
        {
            //Sets state to swimming


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
                anim.SetBool("jump", true);
            }
        }
         

        //else not in water
        else
        {
         */
            if (isGrounded && Input.GetKeyDown(KeyCode.Space))
            {

                anim.SetBool("isGrounded", false);
                rigidbody2D.AddForce(new Vector2(0, jumpForce));
            }
        //}
    }

}
