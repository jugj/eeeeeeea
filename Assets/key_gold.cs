using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_gold : MonoBehaviour
{
    public GameObject door;
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(door);
            Destroy(gameObject);
        }

        

    }
}
