using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;         //we had to create a var

    public float jumpforce;   

    public LayerMask layerground;

    private bool inground;

    public float distancegroundminimum = 1f;
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
        if (inground){
        rb.AddForce(Vector2.up * jumpforce);   //here we will add a force for jump, vector2 give us a type of force, y for up or down, and axis x is for right and left, jumpforce we will to create for to say how much force we will to use
        }
    }
    private void FixedUpdate() //functions that works with physics , we need to use fixedupdate, works each 0.2 sec
     {   
        inground = Physics2D.Raycast(transform.position, Vector2.down, 2f, layerground); //vecto2.down is a direction for down (-1 negative in axis y),distancegroundminimum is a distance, transform.positition is the exact position where dino is. 
    }
}
