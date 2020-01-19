using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelect : MonoBehaviour
{
    public GameObject mapFirst;
    public GameObject mapP;
    public GameObject mapN;

    public void GoBack()
    {
        mapFirst.SetActive(true);

    }
    public void GoNext()
    {
        mapN.SetActive(true);

    }

}
