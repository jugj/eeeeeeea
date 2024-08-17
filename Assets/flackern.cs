using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flackern : MonoBehaviour
{
    public GameObject Light;
    public float Time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator flackerni()
    {
        Light.SetActive(false);
        yield return new WaitForSecondsRealtime(0.1f);
        Light.SetActive(true);
    }

    public IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(Time);
        StartCoroutine(flackerni());
        StartCoroutine(wait());
    }
}
