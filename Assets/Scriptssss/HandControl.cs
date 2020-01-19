using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HandControl : MonoBehaviour
{
    private float count;

    void Start()
    {
        
    }

    void Update()
    {
        if(count>=2)
            SceneManager.LoadScene("001");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            count++;
    }
}
