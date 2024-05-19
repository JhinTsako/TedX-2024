using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public float smoothSpeed = 0.5f;


    private void LateUpdate()
    {

        if (player1 != null && player2 != null)
        {
            Vector3 midpoint = (player1.position + player2.position) / 2f;

            Vector3 desiredPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, midpoint.z-20f);

            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        }
        else if (player1 == null && player2 != null)
        {


            Vector3 desiredPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, player2.transform.position.z-20f);

            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

    }
            else if (player2 == null && player1 != null)
        {


            Vector3 desiredPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, player1.transform.position.z-20f);

            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

    }
}
}
