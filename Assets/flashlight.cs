using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        if(Timer > max -2f)
        {
            Break.SetActive(true);
        }

         if(Timer < max -2f)
        {
            Break.SetActive(false);
        }

          if(Timer < max)
        {
            Jumpscare.SetActive(false);
        }

          if(Timer > max)
        {
            Jumpscare.SetActive(true);
            StartCoroutine(ResetGame());
        }



    }

    public IEnumerator ResetGame()
    {
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("SampleScene");
    } 
}
