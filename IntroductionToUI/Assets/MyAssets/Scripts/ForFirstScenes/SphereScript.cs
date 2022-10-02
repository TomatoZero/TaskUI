using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    private Transform transform;
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    public void SetHeight(float value) 
    {
        Vector3 vector3 = new Vector3(transform.position.x, value, transform.position.z);
        transform.position = vector3;
    }

    public void SetScale(float value)
    {
        transform.localScale = new Vector3(value, transform.localScale.y, value);
    }

    public void SetDistance(float value) 
    {
        Vector3 vector3 = new Vector3(transform.position.x, transform.position.y, value);
        transform.position = vector3;
    }

    public void Move(float value) 
    {
        
    }
}
