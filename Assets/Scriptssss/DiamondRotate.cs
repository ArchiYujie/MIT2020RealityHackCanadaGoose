using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondRotate : MonoBehaviour
{
    public GameObject bubble;
    private Transform FPC;
    private float random;
    private float timer;
    void Start()
    {
        random = Random.Range(5, 100);
        timer = random - 3;
        FPC = GameObject.Find("OVRPlayerController").GetComponent<Transform>();
    }

    void Update()
    {
        Approach();
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(bubble, this.transform.position, Quaternion.identity);
            timer = 100;
        }
        Destroy(this.gameObject, random);
    }
    void Approach()
    {

        if (Mathf.Abs(this.transform.position.x - FPC.position.x) < 2 && Mathf.Abs(this.transform.position.z - FPC.position.z) < 2)
        {
            this.transform.Rotate(Vector3.up * 90 * Time.deltaTime);
        }
        else
            this.transform.Rotate(Vector3.zero);
    }
}
