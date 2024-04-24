using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableBrick : MonoBehaviour
{
    private Rigidbody rb;
    private bool touch=false;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Player")){
            touch=true;
            Debug.Log("Trigger Entered");
        }
    }
    private void AddBrickForce(){
       // Debug.Log("ForceAdded");
       gameObject.GetComponent<AudioSource>().Play();
        float moveForce =10f;
        float horizontalInput = Input.GetAxis("Horizontall");
        float verticalInput = Input.GetAxis("Verticall");

        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput);
if (rb!=null){
        rb.AddForce(moveDirection * moveForce);
}
    }
    void Update()
    {
        if(touch && Input.GetKey(KeyCode.Space)){
            AddBrickForce();
        }
    }
}

























