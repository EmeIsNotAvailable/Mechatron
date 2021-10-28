using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletrobot : MonoBehaviour
{
    public float vel = 5f;
    public int t = 5;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, t);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vel * Time.deltaTime, 0, 0);

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        { 
           
            Destroy(gameObject);

        }
    }
}
