using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeObjectScript : MonoBehaviour
{
    private Transform myTransform;
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    public void SetHeight(float value) 
    {
        Vector3 vector3 = new Vector3(myTransform.position.x, value, myTransform.position.z);
        myTransform.position = vector3;
    }

    public void SetScale(float value)
    {
        myTransform.localScale = new Vector3(value, myTransform.localScale.y, value);
    }

    public void SetDistance(float value) 
    {
        Vector3 vector3 = new Vector3(myTransform.position.x, myTransform.position.y, value);
        myTransform.position = vector3;
    }
}
