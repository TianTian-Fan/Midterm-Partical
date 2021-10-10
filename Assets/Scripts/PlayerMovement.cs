using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 1.0f;
    public float rotateSpeed = 30.0f;

   
     void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        //Horizontal zxis -> left and right keys (or A and D)
        float horizontal = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        //Vertical Axis -> up and down keys (or W and S)
        float vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0, 0, vertical);

    }


}
