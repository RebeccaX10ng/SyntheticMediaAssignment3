using UnityEngine;

public class OrbitAround : MonoBehaviour
{
    public Transform centerObject; // 中心物体
    public float orbitRadius = 2f; // 公转半径
    public float orbitSpeed = 2f; // 公转速度

    void Update()
    {
        // 计算公转位置
        Vector3 orbitPosition = centerObject.position + Quaternion.Euler(0, Time.time * orbitSpeed, 0) * Vector3.forward * orbitRadius;
        
        // 设置物体的位置
        transform.position = orbitPosition;
    }
}
