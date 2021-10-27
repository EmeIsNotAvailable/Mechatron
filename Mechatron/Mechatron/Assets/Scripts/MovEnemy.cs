using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemy : MonoBehaviour
{
    public float vel = 2.5f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate(Vector2.up * Time.deltaTime * vel);
    }
    public void MovimientoX()
    {
        transform.Translate(-1, 0, 0);
        vel = -vel;
    }
}
