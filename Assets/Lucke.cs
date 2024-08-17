using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lucke : MonoBehaviour
{
    public Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("s"))
        {
            col.isTrigger = true;
        }
        else
        {
            col.isTrigger = false;
        }
    }
}
