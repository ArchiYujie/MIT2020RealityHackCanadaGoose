using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotate1 : MonoBehaviour
{
    static public bool isRotate;
    void Start()
    {
        
    }

    void Update()
    {
        if(!isRotate)
            this.transform.Rotate(Vector3.up * 20 * Time.deltaTime);
        else
            this.transform.Rotate(Vector3.up * 0 * Time.deltaTime);
    }
}
