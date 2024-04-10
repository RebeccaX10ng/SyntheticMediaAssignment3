using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float sensitivity = 2f; 

    private float rotationX = 0f;
    private float rotationY = 0f;
    void Update()
    {
       
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        
        rotationX -= Input.GetAxis("Mouse Y") * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotationX, transform.localEulerAngles.x, 0f);
        rotationY -= Input.GetAxis("Mouse X") * sensitivity;
        rotationY = Mathf.Clamp(rotationY, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotationY, transform.localEulerAngles.y, 0f);
    }
}