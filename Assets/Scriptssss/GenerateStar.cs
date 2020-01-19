using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStar : MonoBehaviour
{
    private float a;
    private float b;
    private float c;
    private float x;
    private float z;
    public Light light;
    public Light star;
    public GameObject diamond;
    void Start()
    {
        for(int i =0; i < 50; i++)
        {
            Generate();
        }
        for(int i = 0; i< 200; i++)
        {
            Star();
        }
        for(int i =0; i < 10; i++)
        {
            Diamond();
        }
    }

    void Generate()
    {
        Light l = Instantiate(light);
        a = Random.Range(-250, 250);
        b = Random.Range(-250, 250);
        c = Random.Range(10, 100);
        l.transform.position = new Vector3(a, c, b);
    }
    void Star()
    {
        Light l = Instantiate(star);
        a = Random.Range(-250, 250);
        b = Random.Range(-250, 250);
        c = Random.Range(10, 100);
        l.transform.position = new Vector3(a, c, b);
    }
    void Diamond()
    {
        GameObject temp = Instantiate(diamond);
        x = Random.Range(-10, 10);
        z = Random.Range(-15, 5);
        temp.transform.position = new Vector3(x, -9, z);
    }

}
