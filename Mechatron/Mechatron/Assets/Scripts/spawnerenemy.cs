using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerenemy : MonoBehaviour
{
    bool tiempo=true;
    public float x=2f;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo == true)
        {
            StartCoroutine(Spawn());
            print("orden");
        }
    }
    IEnumerator Spawn()
    {
        tiempo = false;
        Instantiate(prefab, transform.position, transform.rotation);
        yield return new WaitForSeconds(x);
        
        tiempo = true;
        print("spawn");
    }
   

}
