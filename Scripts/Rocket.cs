using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] float speed = 10f;


    private void FixedUpdate()
    {
        
        float hor = Input.GetAxisRaw("Horizontal");
        
         Vector3 temp = transform.position;
         temp.x += speed *hor *Time.deltaTime;
         transform.position = temp;
    }
       
}

