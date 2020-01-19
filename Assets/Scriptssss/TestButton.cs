using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestButton : MonoBehaviour
{
    public GameObject testUI;
    public void TestClick()
    {
        GameObject.Find("Main").SetActive(false);
        testUI.SetActive(true);
    }
    public void TestScene()
    {
        SceneManager.LoadScene(1);
    }

    public void TestMeditate()
    {
        SceneManager.LoadScene(2);
    }
}
