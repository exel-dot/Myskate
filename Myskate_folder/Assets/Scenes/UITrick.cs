using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITrick : MonoBehaviour
{
    Animator anim;
    public Text ollie;
    public Text kickflip;
    public Text manual;
    public Slider slider;
    public Text shovit;
    public Text grint;


    // Start is called before the first frame update
    void Start()
    {
        ollie.gameObject.SetActive(false);
        kickflip.gameObject.SetActive(false);
        manual.gameObject.SetActive(false);
        manual.gameObject.SetActive(shovit);
        grint.gameObject.SetActive(false);
    }
    public void Awake()
    {
        anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ollie.gameObject.SetActive(true);
            manual.gameObject.SetActive(false);
           





        }
        if (anim.GetBool("hybryda")==true)
        {
            ollie.gameObject.SetActive(false);
            kickflip.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            manual.gameObject.SetActive(true); 

        }
        if (anim.GetBool("showit") == true)
        {
            ollie.gameObject.SetActive(false);
            shovit.gameObject.SetActive(true);
        }

        if (slider.value == 1 || slider.value < 0.019f)
        {

            manual.gameObject.SetActive(false);

        }
       




    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Platform")
        {

            ollie.gameObject.SetActive(false);
            kickflip.gameObject.SetActive(false);
            shovit.gameObject.SetActive(false);
           

        }

    }
}
