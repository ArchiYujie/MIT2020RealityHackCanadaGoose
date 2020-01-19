using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIRotateFPC : MonoBehaviour
{
    public Transform FPC;
    static public bool isTouch;
    private List<GameObject> UIs = new List<GameObject>();

    void Start()
    {
        GameObject a = GameObject.Find("UI01");
        GameObject b = GameObject.Find("UI02");
        GameObject c = GameObject.Find("UI03");
        GameObject d = GameObject.Find("UI04");
        GameObject e = GameObject.Find("UI05");
        GameObject f = GameObject.Find("UI06");
        UIs.Add(a);
        UIs.Add(b);
        UIs.Add(c);
        UIs.Add(d);
        UIs.Add(f);
        UIs.Add(e);
    }
    void Update()
    {
        Vector3 dir = new Vector3(FPC.position.x - this.transform.position.x,0, FPC.position.z - this.transform.position.z);
        if (!isTouch)
        {   if (this.transform.localScale.x >.03f)
                this.transform.localScale -= this.transform.localScale * 0.2f * Time.deltaTime;
            this.transform.rotation = Quaternion.LookRotation(dir);
            TestRotate1.isRotate = false;
            //this.transform.LookAt(FPC);
            //this.transform.RotateAround(FPC.position, Vector3.up, 20 * Time.deltaTime);
            //this.transform.Rotate(Vector3.up * 20 * Time.deltaTime, Space.Self);
        }
        else
        {
            TestRotate1.isRotate = true;

            //this.transform.rotation = Quaternion.Lerp(Quaternion.Euler(0,0,0), Quaternion.Euler(0, 360, 0), Time.time/(Time.time+5));
            if (this.transform.localScale.x<.05f)
                this.transform.localScale += this.transform.localScale * 0.3f * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTouch = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTouch = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isTouch = false;
        if (other.CompareTag("Player"))
        {
            
        }
        //Invoke("LoadScene", 1);
    }    
    void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
