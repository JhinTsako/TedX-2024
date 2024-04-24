using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickPlace : MonoBehaviour
{
    // Start is called before the first frame update
        private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag=="Brick")
        {         
             // Check if the GameObject has a Collider component
        Destroy(collision.gameObject.GetComponent<Rigidbody>());

        }
        else {

            Physics.IgnoreCollision(GetComponent<Collider>(), collision.collider);
        }
    }
}
