using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backcheck : MonoBehaviour
{
    public Player ps;

    void OnTriggerStay2D(Collider2D col)
    {
       ps.back = true;
    }

     void OnTriggerExit2D(Collider2D other)
    {
        ps.back = false;
    }
}
