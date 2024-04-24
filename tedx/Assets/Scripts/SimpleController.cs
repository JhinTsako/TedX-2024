using UnityEngine;using System.Globalization;

public class SimpleController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 180f;
    private Rigidbody rb;

    public string horizontalAxis;
    public string verticalAxis;

    public bool isPlayer2 = false;

    public Vector3 initialPosition = new Vector3(0f, 0f, 0f);

    void CheckPosition()
    {
        if (transform.position.y < -10f)
        {
            gameObject.GetComponent<AudioSource>().Play();
            transform.position = new Vector3(0f, 20f, 0f);
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
 

    void Update()
    {
        Move();        
           

    }

    private void Move()
    {
           if (isPlayer2)
        {
              horizontalAxis = "Horizontal2";
            verticalAxis = "Vertical2";
        }
        else
        {
            horizontalAxis = "Horizontal";
            verticalAxis = "Vertical";
        }
              
      
        float horizontalInput = Input.GetAxis(horizontalAxis);
        float verticalInput = Input.GetAxis(verticalAxis);

         Debug.Log(horizontalAxis +"");
        Debug.Log(horizontalInput);
        Debug.Log(verticalInput);

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);

        Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
        targetRotation = Quaternion.RotateTowards(transform.rotation, targetRotation * Quaternion.Euler(new Vector3(0, 90, 0)), 360 * Time.fixedDeltaTime);
        gameObject.GetComponent<Rigidbody>().MoveRotation(targetRotation);

        CheckPosition();
    }
}