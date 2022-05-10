using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataInputManager : MonoBehaviour
{
    public Text txtUserInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowGreetings()
    {
        Debug.Log(float.Parse(txtUserInput.text)*2);
    }
}
