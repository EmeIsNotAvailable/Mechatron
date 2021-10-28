using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public float vel = 1.0f;
    public GameObject bullet;
    public Transform shooter;
    bool tiempo = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxisRaw("Vertical") * vel * Time.deltaTime;
        transform.Translate(0, v, 0);
        if(Input.GetKeyDown(KeyCode.Space)&&tiempo==true)
        {
            Instantiate(bullet, shooter.position, shooter.rotation);
            StartCoroutine(Dispara());
            print("dispara");
        }
    }
    public IEnumerator Dispara()
    {
        print("shoot");
        tiempo = false;
        yield return new WaitForSeconds(0.75f);
        tiempo = true;
        
    }
}
