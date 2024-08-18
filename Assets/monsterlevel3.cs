using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterlevel3 : MonoBehaviour
{
    public GameObject Player;
    public AudioSource lied;
    public float speed;

    public float xstart;
    public float xend;

    public bool right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(Player.transform.position, transform.position);
        print("Distance to other: " + dist);
        lied.volume = 1 - dist / 100 * 3f;


         if(transform.position.x <= xstart)

    {

        right = true;

    }

    if(transform.position.x >= xend)

    {

        right = false;

    }


    if(right)

    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }

    else

    {

        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }
    }
}
