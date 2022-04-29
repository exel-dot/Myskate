using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tmp : MonoBehaviour
{
    public Slider slider;
   
    private float targetProgress = 0f;
    public float FillSpeed = 0.01F;
    bool up;
    bool freeze = false;
   
    public int licznik=0;
    // Start is called before t0.1Fhe first frame update
    void Start()
    {
        slider.value = 0.5f;
        slider.minValue = -0f;
        slider.maxValue = 1f;
        // IncrementProgress(1f);
        slider.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

        


        if (Input.GetKey(KeyCode.S)&& slider.value < 1f && slider.gameObject.activeSelf) //1 value
        {
          
            slider.value += FillSpeed * Time.deltaTime;
            up = false;
        }
        if (Input.GetKey(KeyCode.W)&& slider.value> 0.019f && slider.gameObject.activeSelf) //0value
        {
            slider.value -= FillSpeed * Time.deltaTime;
            up = true;
           

        }
        else if (up != false && slider.value > 0.019f && slider.gameObject.activeSelf)
        {
            slider.value -= FillSpeed * Time.deltaTime;
        }
        else if(slider.value < 1f && slider.gameObject.activeSelf)
        {
            slider.value += FillSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            slider.value = 0.5f;
          
        }
        else if (!slider.gameObject.activeSelf)
        {
            slider.value = 0.5f;

        }








    }
    public void IncrementProgress(float newProgress)
    {

        targetProgress = slider.value += newProgress;
    }
}
