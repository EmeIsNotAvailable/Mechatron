using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject enemigos;
    public GameObject bullet;
  
    float x;
    bool tiempo = true;


    // Update is called once per frame
    void Update()
    {

        x = Random.Range(2.0f, 5.0f);
        if (tiempo == true)
            StartCoroutine(Bullet());

        



    }
    void Start()
    {

    }

    IEnumerator Bullet()
    {
        tiempo = false;

        yield return new WaitForSeconds(x);
        bullet.SendMessage("Spawn");
        tiempo = true;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Fondo")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Hemos chocao");
            enemigos.SendMessage("MovimientoX");


        }
        if (col.gameObject.tag == "Bullet")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Destroy(gameObject);
            print("muerto");


        }
    }

    
}