using UnityEngine;
using System.Collections;

public class SimplePlatformController : MonoBehaviour
{

    [HideInInspector] public bool facingRight = true;
    [HideInInspector] public bool jump = false;
    public float moveForce = 365f;
    public float maxSpeed = 8f;
    public float jumpForce;
    public Transform groundCheck;


    public static bool grounded = false;
    private Animator anim;
    private Rigidbody2D rb2d;
    private SpriteRenderer spriteRenderer;

    
    public float jumpTime;
    public float jumpTimeCounter;



    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        jumpTimeCounter = jumpTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Countdown.timeleft < 0)
        {
            float h = Input.GetAxis("Horizontal") * -1;
            grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

            if (grounded)
            {
                jumpTimeCounter = jumpTime;
            }

            if (Input.GetButtonDown("Jump") && grounded)
            {
                anim.SetInteger("State", 2);
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
                jump = false;
            }

            if (Input.GetButton("Jump") && !jump)
            {
                if (jumpTimeCounter > 0)
                {
                    rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
                    jumpTimeCounter -= Time.deltaTime;
                }
            }

            if (Input.GetButtonUp("Jump"))
            {
                jumpTimeCounter = 0;
                jump = true;
            }


            if (h > 0)
            {
                spriteRenderer.flipX = false;
                anim.SetInteger("State", 1);
            }
            else if (h < 0)
            {
                spriteRenderer.flipX = true;
                anim.SetInteger("State", 1);
            }



            if (h == 0 && !grounded)
            {
                anim.SetInteger("State", 2);
            }


            if (h > 0 && !grounded || h < 0 && !grounded)
            {
                anim.SetInteger("State", 2);
            }

            if (h == 0 && grounded)
                anim.SetInteger("State", 0);




            if (h * rb2d.velocity.x < maxSpeed)
                rb2d.velocity = new Vector2(h * moveForce, rb2d.velocity.y);

            if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
                rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

        }
    }
    


}