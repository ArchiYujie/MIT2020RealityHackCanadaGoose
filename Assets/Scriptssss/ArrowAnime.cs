using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAnime : MonoBehaviour
{
    
    void Update()
    {
        this.transform.Rotate(Vector3.forward * 20 * Time.deltaTime);
        this.transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time/5, 0.1f)+.5f, transform.position.z);
    }
}
