using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class raumschiff : MonoBehaviour
{
    public float Geschwindigkeit;
    // Start is called before the first frame update
    void Start()
    {
    
    }


    // Update is called once per frame
    
void Update(){

    if(Input.GetKey("up")){
         transform.Translate(Vector2.up*Geschwindigkeit*Time.deltaTime,Space.World);
    }
    
    if(Input.GetKey("down")){
         transform.Translate(Vector2.down*Geschwindigkeit*Time.deltaTime,Space.World);
    }
    
    if(Input.GetKey("right")){
         transform.Translate(Vector2.right*Geschwindigkeit*Time.deltaTime,Space.World);
    }

    if(Input.GetKey("left")){
         transform.Translate(Vector2.left*Geschwindigkeit*Time.deltaTime,Space.World);
    }  
}

   void OnTriggerEnter2D(Collider2D other){
      Destroy(gameObject);
     Destroy(other.gameObject);
}
}

     