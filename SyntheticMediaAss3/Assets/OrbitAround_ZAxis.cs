using UnityEngine;

public class OrbitAroundZ : MonoBehaviour
{
    public Transform centerObject;
    public float orbitRadius = 2f; 
    public float orbitSpeed = 2f; 

    void Update()
    {
        
        Vector3 orbitPosition = centerObject.position + new Vector3(Mathf.Sin(Time.time * orbitSpeed) * orbitRadius, Mathf.Cos(Time.time * orbitSpeed) * orbitRadius,0f);
        transform.position = orbitPosition;
    }
}