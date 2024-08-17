using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_silber : MonoBehaviour
{
    public GameObject chestopen;
    public GameObject chestclosed;
    public GameObject Sound;
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Sound.SetActive(false);
            Sound.SetActive(true);
            chestclosed.SetActive(false);
            chestopen.SetActive(true);
            Destroy(gameObject);
        }
}
}