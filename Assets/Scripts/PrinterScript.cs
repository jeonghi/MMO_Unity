using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterScript : MonoBehaviour {
    
    void Start () 
    {
        PrintManager.Instance.PrintAllEvent += PrintMyName;
    }

    void PrintMyName(string s)
    {
        Debug.Log(name+" is " + s);
    }

    void OnDestroy()
    {
        PrintManager.Instance.PrintAllEvent -= PrintMyName;
    }
}