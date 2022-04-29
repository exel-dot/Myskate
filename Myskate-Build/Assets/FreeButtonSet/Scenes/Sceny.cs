using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sceny : MonoBehaviour
{
    // Start is called before the first frame update

    public void ZmienScene()
    {
        SceneManager.LoadScene(1);
    }
    public void Wyjdz()
    {
        Application.Quit();
    }
    public void wyjdzzinstrukcji()
    {
        SceneManager.LoadScene(0);
    }
    public void wejdzdoinstrukcji()
    {
        SceneManager.LoadScene(2);
    }
    
}
