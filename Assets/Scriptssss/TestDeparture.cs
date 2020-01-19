using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDeparture : MonoBehaviour
{
    public OVRInput.Button testB;
    void Start()
    {
        
    }

    void Update()
    {
        if (OVRInput.GetDown(testB))
        {

        }
    }
}
