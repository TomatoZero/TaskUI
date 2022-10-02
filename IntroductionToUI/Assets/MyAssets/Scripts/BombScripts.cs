using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScripts : MonoBehaviour
{
    private CanvasRenderer spite;

    public void Start()
    {
        spite = GetComponent<CanvasRenderer>();
    }

    public void TurnRed() 
    {
        spite.SetColor(color:Color.red);
    }
}
