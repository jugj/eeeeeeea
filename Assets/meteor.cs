using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {       transform.Translate(Vector2.left*Geschwindigkeit*Time.deltaTime, Space.World);
        
    }

    // Update is called once per frame
    void Update()
    {public float Geschwindigkeit;
        
    }
}
