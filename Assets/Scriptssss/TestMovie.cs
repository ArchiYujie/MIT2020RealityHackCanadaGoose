using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovie : MonoBehaviour
{
    public MovieTexture _Movie;

    void Start()
    {
        GetComponent<Renderer>().material.mainTexture = _Movie;
        _Movie.Play();
    }
}
