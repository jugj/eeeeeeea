using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontcheck : MonoBehaviour
{
    public Player ps;

    void OnTriggerStay2D(Collider2D col)
    {
       ps.front = true;
    }

     void OnTriggerExit2D(Collider2D other)
    {
        ps.front = false;
    }
}
