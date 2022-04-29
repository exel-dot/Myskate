using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera1 : MonoBehaviour
{
    
    //[SerializeField]
   // public Transform target;
    [SerializeField]
    public float a;
    [SerializeField]
    public float b;
    [SerializeField]
    public float c;
    [SerializeField]
    public GameObject player;

    [SerializeField]
    public float sideOffset;

    private Vector3 offset;
    private Vector3 finalOffset;
    private Vector3 camOffset;
    private bool toggleSideOffset;
    private bool zoomed;





    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        finalOffset = offset;
        toggleSideOffset = true;
        finalOffset.x += sideOffset;
    }

    // Update is called once per frame
   private void Update()
    {
        //  transform.position = target.position - new Vector3(a, b, c);
        //transform.position=Vector3.Lerp(transform.position,()
        Toggleside();

        //transform.position = target.position - new Vector3(a,b,c);


    }
    private void LateUpdate()
    {
        Rotate();
        transform.position = Vector3.Lerp(transform.position, (player.transform.position + finalOffset), 9005f);
        transform.LookAt(player.transform.position);
    }


    

    void Toggleside()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (toggleSideOffset)
            {
                toggleSideOffset = false;
                finalOffset.x -= (2 * sideOffset);
            }
            else
            {
                toggleSideOffset = true;
                finalOffset.x += (2 * sideOffset);
            }

            toggleSideOffset = false;
            finalOffset.x -= (2 * sideOffset);



        }
    }
    void Rotate()
    {
      //  finalOffset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 4f, Vector3.up) * finalOffset;
    }

}
