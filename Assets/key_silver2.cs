using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_silver2 : MonoBehaviour
{
    public GameObject door2;
    public GameObject Sound2;
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(door2);
            Sound2.SetActive(false);
            Sound2.SetActive(true);
            Destroy(gameObject);
        }

        

    }
}
