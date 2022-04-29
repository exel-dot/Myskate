using UnityEngine;
using System.Collections;

public class distance : MonoBehaviour
{
    public Transform other;
    Animator anim;
    void Update()
    {
       
        
        
        float dist = Vector3.Distance(other.position, transform.position);
       // Debug.Log("Distance to other: " + dist);
        //if (dist < 1.5f)
        //{
        //    anim.SetTrigger("grind");
        //}
        //anim.SetTrigger("grind");
        if (dist < 1.5f)
        {
            Debug.Log("zamaly");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            anim.SetTrigger("grind");
        }




    }
}
