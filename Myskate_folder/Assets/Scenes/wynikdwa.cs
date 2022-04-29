using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class wynikdwa : MonoBehaviour
{
    [SerializeField]
    Animator anim;
    public Text label;
    public float wynik = 0;
    public bool start = false;
    public Text man;
    float currentTime = 0;
    public Slider slider;
   
    // Start is called before the first frame update
    void Start()
    {
        float currentTime = 0f;
        start = false;
      
        man.enabled = false;


    }
    public void Awake()
    {
        anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        label.text = wynik.ToString();
        Liczeniewyniku();
    }
   
   
    public void Liczeniewyniku()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            start = true;
            man.enabled = true;
            //gamesPlayed = Integer.parseInt(gamesPlayedText.text);



        }
        if (start)
        {
            currentTime = currentTime + 130 * Time.deltaTime;
        }
        if (slider.value == 1)
        {
            currentTime = 0;
            start = false;
            wynik = (wynik + currentTime);
            

            man.enabled = false;
        }
        if (slider.value < 0.019f)
        {
            currentTime = currentTime * Time.deltaTime;


            man.text = currentTime.ToString();//To string 00

            start = false;

            wynik = (wynik + currentTime);

            man.enabled = false;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            start = false;
            currentTime = 0;
            wynik = wynik + 0;


        }
    }
    public void kickfliplus()
    {
        wynik = wynik + 10;
    }
    public void shovitplus()
    {
        wynik = wynik + 15;
    }
    public void grindplus()
    {
        wynik = wynik + 15;
    }
    public void specialplus()
    {
        wynik = wynik + 50;
    }
    public void nieudanytrick()
    {
        wynik = wynik - 30;
    }
}
