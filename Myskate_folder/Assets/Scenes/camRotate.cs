using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camRotate : MonoBehaviour
{
    public Vector2 turn;
    public float sens = .5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            turn.y += .30f;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            turn.x += .30f;
        }
       
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
