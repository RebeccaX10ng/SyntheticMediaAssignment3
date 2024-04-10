using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f; // 摄像机移动速度
    public float rotateSpeed = 5f; // 摄像机旋转速度

    void Update()
    {
        // WASD移动
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // 鼠标旋转视角
        if (Input.GetMouseButton(1)) // 按住鼠标右键
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            transform.Rotate(Vector3.up, mouseX * rotateSpeed * Time.deltaTime);
            transform.Rotate(Vector3.left, mouseY * rotateSpeed * Time.deltaTime);
        }
    }
}
