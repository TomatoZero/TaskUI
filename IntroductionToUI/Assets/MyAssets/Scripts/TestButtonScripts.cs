using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButtonScripts : MonoBehaviour
{
    public void ClickTest()
    {
        Debug.Log("Clicked");
    }

    public void ClickTest(string str)
    {
        Debug.Log(str);
    }
}
