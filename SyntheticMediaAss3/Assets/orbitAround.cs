using UnityEngine;

public class OrbitAround : MonoBehaviour
{
    public Transform centerObject; 
    public float orbitRadius = 2f; 
    public float orbitSpeed = 2f; 

    void Update()
    {
 
        Vector3 orbitPosition = centerObject.position + Quaternion.Euler(0, Time.time * orbitSpeed, 0) * Vector3.forward * orbitRadius;
        
      
        transform.position = orbitPosition;
    }
}
