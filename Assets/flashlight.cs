using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class flashlight : MonoBehaviour
{
    public float Timer;
    public float max;
    public GameObject Jumpscare;
    public GameObject Break;
    public GameObject scream;

    public Player ps;

    public Light2D myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if(Timer > max -2f)
        {
            myLight.intensity = 0.5f;
            Break.SetActive(true);
        }

         if(Timer < max -2f)
        {
            myLight.intensity = 1f;
            Break.SetActive(false);
        }

          if(Timer < max)
        {
            Jumpscare.SetActive(false);
        }

          if(Timer > max)
        {
            StartCoroutine(ResetGame());
            scream.SetActive(true);
            Jumpscare.SetActive(true);
            ps.Jumpscare = true;
            myLight.intensity = 0;
            
            
        }



    }

    public IEnumerator ResetGame()
    {
        yield return new WaitForSecondsRealtime(0.6f);
        SceneManager.LoadScene("SampleScene");
    } 
}
