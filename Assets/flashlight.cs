using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public float Timer;
    public float max;
    public GameObject Jumpscare;
    public GameObject Break;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if(Timer > max -1)
        {
            Break.SetActive(true);
        }

          if(Timer > max)
        {
            Jumpscare.SetActive(true);
        }

    }


}
