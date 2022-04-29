using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wskaznikmocy : MonoBehaviour
{
    public Slider wskaznik;
    public bool prawda;
    public Text boardslide;
    public Text ollie;
    Animator anim;
    public Text specialtext;

    // Start is called before the first frame update
    void Start()
    {
        prawda = false;
        boardslide.gameObject.SetActive(false);


    }
    public void Awake()
    {
        anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
       
        if (wskaznik.value >= 1)
        {
            prawda = true;


        }
        if (Input.GetKeyDown(KeyCode.F))
        {




            if (prawda)
            {
                anim.SetTrigger("special");
                prawda = false;
                wskaznik.value = 0f;
                specialtext.enabled = true;
            }







        }

    }

    public void Dodawanieollie()
    {
        wskaznik.value = wskaznik.value + 0.02f;
    }
    public void Dodawaniekickflip()
    {
        wskaznik.value = wskaznik.value + 0.08f;
    }
   
    public void Dodawanieshowit()
    {
        wskaznik.value = wskaznik.value + 0.07f;
    }
    public void Dodawaniegrind()
    {
        wskaznik.value = wskaznik.value + 0.10f;
    }
    public void Zerowanie()
    {
        if (prawda == false)
        {
            wskaznik.value = wskaznik.value - 0.15f;
        }


    }
    public void Zerowanienieudany()
    {
        
            wskaznik.value = 0f;
        


    }
    public void Wlaczenie()
    {
        ollie.gameObject.SetActive(false);
        boardslide.gameObject.SetActive(true);

    }
    public void Wyaczenie()
    {
        boardslide.gameObject.SetActive(false);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Platform")
        {

            boardslide.gameObject.SetActive(false);
            specialtext.enabled = false;

        }

    }


}
