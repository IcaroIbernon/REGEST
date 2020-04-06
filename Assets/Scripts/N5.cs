using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class N5 : MonoBehaviour
{
    public bool con;
    public string pattern;
    public GameObject inputField; 
    public GameObject textDisplay;

    public void Main()
    {
    
    List<string> names = new List<string>()
    {
    "435-ABC", "D4DA-3355", "ABC-1234", "BDE.4356", "BLF-1233", "BFC-A123"
    };
    List<string> correto = new List<string>()
    {
    "ABC-1234", "BLF-1233"
    };
    List<string> resposta = new List<string>();
    pattern = inputField.GetComponent<Text>().text;
    foreach (string name in names)
    {
        if (Regex.IsMatch(name, pattern)){
        resposta.Add(name);
        }
    }
    con = resposta.SequenceEqual(correto);
    textDisplay.GetComponent<Text>().text = con.ToString();
    if (con == true){
        SceneManager.LoadScene("Final");
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Nivel2"));
    }
    }
}