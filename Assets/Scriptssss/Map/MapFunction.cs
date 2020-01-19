using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapFunction : MonoBehaviour
{

    public GameObject map1;
    public GameObject map2;
    public GameObject map3;
    public GameObject UI6;
    public void Goback()
    {
        map3.SetActive(true);
        map1.SetActive(false);
    }
    public void MapAct()
    {
        map1.SetActive(false);
        map2.SetActive(true);
    }
    public void SetUI()
    {
        UI6.SetActive(true);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
    public void Transit()
    {
        map1.GetComponent<Animator>().SetBool("isT", true);
        Invoke("OnDestroy", 1f);
        
    }
    private void OnDestroy()
    {
        map2.SetActive(true);
        map1.SetActive(false);
    }
}
