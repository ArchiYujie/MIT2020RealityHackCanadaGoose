using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAnimeForUI : MonoBehaviour
{

    void Update()
    {
        this.transform.Rotate(Vector3.forward * 20 * Time.deltaTime);
        this.transform.localPosition = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 3, 2)+7, transform.position.z);
    }
}
