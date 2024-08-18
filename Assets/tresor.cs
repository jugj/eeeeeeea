using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class tresor : MonoBehaviour
{
    public int code = 0;
    public TMP_Text txt;
    public int richtig;
    public door3 ds;

    public int numb;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = code.ToString();
        
        if(code == richtig)
        {
            if(numb == 1)
            {
                ds.richtig1 = 1;
            }
             if(numb == 2)
            {
                ds.richtig2 = 1;
            }
             if(numb == 3)
            {
                ds.richtig3 = 1;
            }
            
        }
        else
        {
                if(numb == 1)
            {
                ds.richtig1 = 0;
            }
             if(numb == 2)
            {
                ds.richtig2 = 0;
            }
             if(numb == 3)
            {
                ds.richtig3 = 0;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {

                 if(code != 9)
                {
                    code += 1;
                }
                else
                {
                    code = 0;
                }
               

            
        
    }
}

}