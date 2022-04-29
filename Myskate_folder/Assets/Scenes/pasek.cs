using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pasek : MonoBehaviour
{
    public Scrollbar passek;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        Vector3  pasekPos = Camera.main.WorldToScreenPoint(this.transform.position);
        passek.transform.position = pasekPos;
        if (Input.GetKeyDown(KeyCode.T))
        {


            for (int i = 0; i < 20; i++)
            {
                passek.value = passek.value+ +0.3f;
            }
           





        }
        if (Input.GetKeyDown(KeyCode.G))
        {


            for (int i = 0; i < 20; i++)
            {
                passek.value = passek.value -0.3f;
            }






        }
    }

}
