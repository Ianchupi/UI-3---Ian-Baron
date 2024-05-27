using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class LogInManager : MonoBehaviour
{

    public string password = "contraseña";
    public InputField inputContraseña;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CheckPassword()
    {
        if (inputContraseña.text == password)
        {
            Debug.Log("Access Granted");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }
}
