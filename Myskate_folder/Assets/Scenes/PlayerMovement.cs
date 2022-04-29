using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Slider slider;
    public Text wynik;
  

    Animator anim;
    [SerializeField]
    float movementVelocity;
    [SerializeField]
    float jumpVelocity;


    [SerializeField]
    private float a;
    [SerializeField]
    private float b;
    [SerializeField]
    private float c;
    [SerializeField]
    private float d;


    float maxSpeed = 30.0f;
    float minSpeed = -30.0f;
    int jumpCounter = 0;
    int maxJumpCount = 1;
    bool jump = true;
    bool czymoze = false;
    bool czymanual = true;
    int licznik = 0;
    bool ustawieniedomanuala = true;
    bool autojazda = false;

    int liczba = 200;
    int wynikliczbowy;
    public Transform other;
    public Transform other2;
    public Transform other3;




    public void Start()
    {
        anim.SetBool("nieudm", false);

       
}
    public void Awake()
    {
        anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();

    }
    void Roation()
    {
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * 900f, 0));

    }
    public void Grind()
    {
        float dist = Vector3.Distance(other.position, transform.position);
        float dist2 = Vector3.Distance(other2.position, transform.position);
        float dist3 = Vector3.Distance(other3.position, transform.position);
        if ((dist < 6f || dist2 < 6f || dist3 < 6f) && Input.GetKey(KeyCode.Z))
        {

            anim.SetBool("grind", true);
          

        }
        else
        {
            anim.SetBool("grind", false);
        }
       
    }
   




    private void Update()
    {

        Grind();
        Roation();


        if (Input.GetKeyDown(KeyCode.Space))
        {


            jump = true;
            czymoze = true;
            anim.SetTrigger("ollie");
            Debug.Log("czymozefalse");
            anim.SetBool("nieudane", false);
            ustawieniedomanuala = true;
            anim.SetBool("nieudm", false);
            slider.gameObject.SetActive(false);







        }
        if (!slider.gameObject.activeSelf)
        {
            anim.SetBool("nieudm", false);
        }
        if (!slider.gameObject.activeSelf)
        {
            anim.SetBool("udam", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {


            if (ustawieniedomanuala == true)
            {
                slider.gameObject.SetActive(true);
                anim.SetTrigger("manual");
                slider.value = 0.5f;
                ustawieniedomanuala = false;


            }


        }

        if (Input.GetKeyDown(KeyCode.A))
        {

            if (czymoze)
            {
                anim.SetTrigger("hybryda");
                Debug.Log("hybryda");


            }

        }

        if (Input.GetKeyDown(KeyCode.D))
        {



            if (czymoze)
            {
                anim.SetTrigger("showit");
            }
               




        }
       
        if (slider.value == 1)
        {


            anim.SetTrigger("nieudm");
            slider.gameObject.SetActive(false);
        }
        if (slider.value < 0.019f)
        {

            anim.SetTrigger("udam");
            ustawieniedomanuala = true;
            slider.gameObject.SetActive(false);



        }






    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 heightPosition = GetComponent<Rigidbody>().position;
        if (heightPosition[1] >= -10000.0f)
        {
            Vector3 currentVelocity = GetComponent<Rigidbody>().velocity;
            if (Input.GetKey("up"))
            {
                currentVelocity += new Vector3(0.0f, 0.0f, movementVelocity);
                Debug.Log("qqqqqqqqqqqqqqqqqqqqq");


            }
            if (Input.GetKey("down"))
            {
                currentVelocity -= new Vector3(0.0f, 0.0f, movementVelocity);

            }
            if (Input.GetKey("left"))
            {
                currentVelocity -= new Vector3(movementVelocity, 0.0f, 0.0f);

            }
            if (Input.GetKey("right"))
            {
                currentVelocity += new Vector3(movementVelocity, 0.0f, 0.0f);

            }
            if (jump)
            {
                if (jumpCounter < maxJumpCount)
                {
                    currentVelocity = new Vector3(currentVelocity[0], jumpVelocity, currentVelocity[2]);
                    currentVelocity = new Vector3(currentVelocity[0], jumpVelocity, currentVelocity[2]);
                    currentVelocity = new Vector3(currentVelocity[0], jumpVelocity, currentVelocity[2]);
                    currentVelocity = new Vector3(currentVelocity[0], jumpVelocity, currentVelocity[2]);
                    jumpCounter++;
                    Debug.Log(jumpCounter);
                }
                jump = false;
            }
            for (int i = 0; i < 3; i++)
            {
                if (currentVelocity[i] >= maxSpeed)
                {
                    currentVelocity[i] = maxSpeed;
                }
                if (currentVelocity[i] <= minSpeed)
                {
                    currentVelocity[i] = minSpeed;
                }
            }

            //Debug.Log(currentVelocity);
            GetComponent<Rigidbody>().velocity = currentVelocity;



        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Platform")
        {
            jumpCounter = 0;
            Debug.Log(jumpCounter);
            Debug.Log("zdarzenie");
            anim.SetTrigger("nieudane");
            anim.SetBool("hybryda", false);
            anim.SetBool("showit", false);
            anim.SetBool("grind", false);
            

            czymoze = false;
            anim.SetBool("ziemia", true);
          


        }
        else
        {
            anim.SetBool("ziemia", false);
        }

        
    }
}
