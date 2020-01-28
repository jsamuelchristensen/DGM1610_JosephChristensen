using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.58f);
    }

    // detect collison with another object
    public void OnCollisionEnter(Collision other)
    {
    if (other.gameObject.CompareTag("Floor"))//Primary

    {
            Debug.Log("Colliding with Floor");
    }
    else if (other.gameObject.CompareTag("Obstacle"))//Secondary
    {
            Debug.Log("Colliding with Obstacle");

    }
    else //Default, tertiary
    {
            Debug.Log("...");
    }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You entered the trigger!");
    }
}
