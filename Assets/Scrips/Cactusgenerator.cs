using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactusgenerator : MonoBehaviour
{
    public GameObject cactusprefab;

    public float delayinitial;

    public float delaybetweencactus;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("cactusgenerator", delayinitial, delaybetweencactus);


    }

    private void cactusgenerator()
    {
        Instantiate(cactusprefab, transform.position, Quaternion.identity);
    }
}
