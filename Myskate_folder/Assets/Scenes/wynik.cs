using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wynik : MonoBehaviour
{
    [SerializeField]
    Animator anim;
   
    public Text Wynik ;
    public double wynikk = 0.0000;
    
    public int kickflip = 5;
    public int ollie = 1;
    public int shovit = 10;
    public int nieudane = 150;
    float currentTime = 0;
    float startingTime = 10f;
    public Text man;
    public Slider slider;
    public bool start = false;
    float liczba = 0;
    int ll = 0;
  
    int kom = 1;

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
       
        Liczeniewyniku();
        // combo.text = kom.ToString();
        wyswietlanie();



    }
    public void wyswietlanie()
    {
        Wynik.text = wynikk.ToString("0000");
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
            wynikk = (wynikk + currentTime);

            man.enabled = false;
        }
        if (slider.value < 0.019f)
        {
            currentTime = currentTime * Time.deltaTime;


            man.text = currentTime.ToString();//To string 00

            start = false;
            liczba = (int)currentTime;
            wynikk = (wynikk + currentTime);

            man.enabled = false;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            start = false;
            currentTime = 0;
            wynikk = wynikk + 0;


        }
        man.text = currentTime.ToString("00");//To string 00







    }
    public void Dodawaniedowyniku()
    {
        wynikk = 0;
        
    }
   
}
