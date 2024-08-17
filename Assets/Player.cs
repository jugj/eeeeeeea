using System;
using UnityEngine;
public class Player : MonoBehaviour
{
    public flashlight fs;
    public float horizontal;
    public float speed = 8f;
    public float jumpingPower = 16f;
    public bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Transform frontcheck;
    [SerializeField] private Transform backcheck;
    [SerializeField] private LayerMask groundLayer;
    public GameObject Flashlight;
    private bool flashlighton;

    public bool front;
   
    public bool back;

    public Animator Animator;
    

    

    void Update()
    {

        fs.Timer += -Time.deltaTime * 0.3f;

        if (Input.GetKey("d"))
        {
            if(isFacingRight && !front)
            {
                horizontal = 1;
                Animator.SetBool("run", true);
            }
            if(!isFacingRight && !back)
            {
                horizontal = 1;
                Animator.SetBool("run", true);
            }
        }
        else if (Input.GetKey("a"))
        {
            if(!isFacingRight && !front)
            {
                horizontal = -1;
                Animator.SetBool("run", true);
            }
            if(isFacingRight && !back)
            {
                horizontal = -1;
                Animator.SetBool("run", true);
            }
        }
        
        if(!Input.GetKey("a") && !Input.GetKey("d"))
        {
            horizontal = 0;
            
            Animator.SetBool("run", false);
            
        }

        if(Input.GetKeyDown("e"))
        {
            if(flashlighton)
            {
                flashlighton = false;
            }
            else
            {
                flashlighton = true;
            }
           
        }

            if(flashlighton)
            {
                Flashlight.SetActive(true);
            }
            else
            {
                Flashlight.SetActive(false);
            }
    


        

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            
        }


       

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();

        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    
    
  

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "ladder")
        {
            if(Input.GetKey("w"))
            {
                rb.velocity = new Vector2(rb.velocity.x, speed * 0.3f);
                Animator.SetBool("run", false);
            }
            
        }
    }


}
