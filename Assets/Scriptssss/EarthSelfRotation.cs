using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthSelfRotation : MonoBehaviour
{
    
    void Update()
    {
        this.transform.Rotate(Vector3.up * -2 * Time.deltaTime);
    }
}
