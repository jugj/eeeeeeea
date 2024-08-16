using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    
    public float speed;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
                                                                                                                                          
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
            transform.Translate(Vector2.up*speed*Time.deltaTime, Space.World);
        if(Input.GetKey("s"))   
            transform.Translate(Vector2.up*speed*Time.deltaTime*-1, Space.World);
        if(Input.GetKey("a"))
            transform.Translate(Vector2.left*speed*Time.deltaTime, Space.World);
        if(Input.GetKey("d"))   
            transform.Translate(Vector2.left*speed*Time.deltaTime*-1, Space.World);   
    }
}
