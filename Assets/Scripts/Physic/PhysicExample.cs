using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Touched other object"+collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Touching other object" + collision.gameObject.name);
    }

    //  when we use trigerenter we not have a should rigidbody,
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("player"))
            Debug.Log("Touching player object");
        // comparetag better tan tag to fps 
    }

}
