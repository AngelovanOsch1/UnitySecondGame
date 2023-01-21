using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PressPlay : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        string[] arguments = Environment.GetCommandLineArgs();

        foreach (string arg in arguments)
        {
            text.text = arg.ToString();
        }
    }

    public void OnPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void OnQuit()
    {
        text.text = "test";
    }

   // private string GetArg(string name)
  //  {
     //   var args = System.Environment.GetCommandLineArgs();
     //   for (int i = 0; i < args.Length; i++)
    //    {
    //        if (args[i] == name && args.Length > i + 1)
//{
      //          text.text = args[i];
      //          return args[i + 1];

     //       }
    //    }
   //     return null;
  //  }
}
