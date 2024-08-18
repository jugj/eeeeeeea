using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door3 : MonoBehaviour
{
    public int richtig1;
    public int richtig2;
    public int richtig3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(richtig1 == 1 && richtig2 == 1 && richtig3 == 1)
        {
            Destroy(gameObject);
        }
    }
}
