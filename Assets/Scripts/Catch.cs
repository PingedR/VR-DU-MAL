using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour
{
    Counter counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = FindObjectOfType<Counter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Family"))
        {
            //collision.gameObject.SetActive(false);
            Debug.Log("Family");
            counter.IncrementContador();
        }
   
    } 
}
