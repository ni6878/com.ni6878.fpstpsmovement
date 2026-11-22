using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]  private float speed = 5.0f;

    void Start()
    {
       
    }

     
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Move(new Vector2(0,1));
        }
        if (Input.GetKey(KeyCode.S))
        {
            Move(new Vector2(0, -1));
        }
        if (Input.GetKey(KeyCode.A))
        {
            Move(new Vector2(-1,0));
        }
        if(Input.GetKey(KeyCode.D))
        {
            Move(new Vector2(1,0));
        }

    }
    void Move(Vector2 inputValue) 
    {
        Vector3 Temp = new Vector3(inputValue.x, 0, inputValue.y);
        transform.Translate(Temp * speed*Time.deltaTime);
        
    }
}