using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMov : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10;
 



    void Update()
    {
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * X + transform.forward * Z;

        controller.Move(move * speed * Time.deltaTime);



    }



}
