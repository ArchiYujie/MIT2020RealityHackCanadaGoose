using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkCamera : MonoBehaviour
{
    public Transform FPC;
    void Start()
    {
        
    }


    void Update()
    {
        FPC.position = new Vector3(this.transform.position.x, 0, this.transform.position.z);
    }
}
