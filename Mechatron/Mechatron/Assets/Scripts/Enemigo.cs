using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    // Start is called before the first frame update
  
    public GameObject enemigos;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Fondo")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Hemos chocao");
            enemigos.SendMessage("MovimientoX");
            
        }
    }
}
