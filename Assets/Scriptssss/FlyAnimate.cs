using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAnimate : MonoBehaviour
{
    public Transform center;
    private bool stop;
    void Start()
    {
        
    }

    void Update()
    {
        //this.transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        if(!stop)
            this.transform.RotateAround(center.position, Vector3.forward, 20 * Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        stop = true;
    }
}
