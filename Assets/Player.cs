using System;
using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
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

    public bool Jumpscare;

    public bool Level2;  
    public GameObject Pulsob;
    public TMP_Text pulstxt;
    public float puls;
    public GameObject pulssound;
    public bool Level2once;

    public GameObject Atmenslow;
    public GameObject Atmenfast;

    public GameObject Jumpscare2;

    public Light2D flashlight;

    public GameObject scream2;
    
    void Start()
    {
        Jumpscare = false;
    }

    void Update()
    {


        if(!Level2)
        {
            Atmenslow.SetActive(false);
            Atmenfast.SetActive(false);
        }

        if(Level2)
        {
            Pulsob.SetActive(true);
            pulstxt.text =  ((int) puls).ToString();

            if(Input.GetKey("d"))
            {
                puls += Time.deltaTime * 1.5f;
            }
            
             if(Input.GetKey("a"))
            { 
                puls += Time.deltaTime * 1.5f ;
            }

             if(!Input.GetKey("a") && !Input.GetKey("d"))
            {
                puls += -Time.deltaTime * 1.6f;
            }

             if(Input.GetKeyDown("space"))
            {
                puls += 2.5f;
            }

            

            if(puls < 50)
            {
                scream2.SetActive(true);
                flashlight.intensity = 0f;
                Jumpscare2.SetActive(true);
                Jumpscare = true;
                StartCoroutine(ResetGame());
            }

              if(puls > 120)
            {
                scream2.SetActive(true);
                flashlight.intensity = 0f;
                Jumpscare2.SetActive(true);
                StartCoroutine(ResetGame());
            }


             if(puls < 60)
            {
                Atmenslow.SetActive(true);
            }

              if(puls > 110)
            {
                Atmenfast.SetActive(true);
            }

             if(puls > 60)
            {
                Atmenslow.SetActive(false);
            }

              if(puls < 110)
            {
                Atmenfast.SetActive(false);
            }


            
        }

        if(Level2 && !Level2once)
        {
            StartCoroutine(pulss());
            Level2once = true;
        }

        if(Jumpscare)
        {
            horizontal = 0;
        }

        if(!Jumpscare)
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

         if(coll.gameObject.tag == "Level2")
        {
            Level2 = true;
            
        }

    }

    public IEnumerator pulss()
    {

        pulssound.SetActive(false);
        yield return new WaitForSeconds(15f / puls);
        pulssound.SetActive(true);
        yield return new WaitForSeconds(15f / puls);
        StartCoroutine(pulss());
    }

       public IEnumerator ResetGame()
    {
        yield return new WaitForSecondsRealtime(0.6f);
        SceneManager.LoadScene("SampleScene");
    } 
}
