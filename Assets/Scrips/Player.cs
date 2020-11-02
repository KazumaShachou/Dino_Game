using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;         //we had to create a var

    public float jumpforce;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jump();
        }
    
    }
    void jump() {
        rb.AddForce(Vector2.up * jumpforce);   //here we will add a force for jump, vector2 give us a type of force, y for up or down, and axis x is for right and left, jumpforce we will to create for to say how much force we will to use
    }

}
