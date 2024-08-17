using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_gold : MonoBehaviour
{
    public GameObject door;
    public GameObject Sound;
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(door);
            Sound.SetActive(false);
            Sound.SetActive(true);
            Destroy(gameObject);
        }

        

    }
}
