using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinomove : MonoBehaviour
{

    public Vector2 direction;

    public float speed;

      private  void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime); //vector 3 increase axis z, deltatime give to up the information about the time absolute between 1 frame and other (the time of each frame)
    }
}
