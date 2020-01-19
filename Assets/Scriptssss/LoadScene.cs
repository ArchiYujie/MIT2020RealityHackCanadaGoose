using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    public OVRInput.Button chooseMode;
    private bool isTouching;
    void Start()
    {
        
    }

    void Update()
    {
        if (isTouching && UIRotateFPC.isTouch && OVRInput.GetDown(chooseMode))
            SceneManager.LoadScene(1);

    }
    private void OnTriggerStay(Collider other)
    {
        isTouching = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isTouching = false;
    }
}
