﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    public void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }

    // Update is called once per frame
   
}
