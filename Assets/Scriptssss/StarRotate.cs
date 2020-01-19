using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotate : MonoBehaviour
{
    public Transform FPC;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Approach();
    }
    void Approach()
    {
        Vector3 direction = new Vector3(FPC.position.x - transform.position.x, 0, FPC.position.z - transform.position.z);
        if (Mathf.Abs(this.transform.position.x - FPC.position.x) < 2 && Mathf.Abs(this.transform.position.z - FPC.position.z) < 2)
        {
            
            animator.SetBool("isApproach", true);
            this.transform.rotation = Quaternion.LookRotation(direction);
        }
        else
            animator.SetBool("isApproach", false);
    }
}
