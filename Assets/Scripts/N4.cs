using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class N4 : MonoBehaviour
{
    public bool con;
    public string pattern;
    public GameObject inputField; 
    public GameObject textDisplay;

    public void Main()
    {
    
    List<string> names = new List<string>()
    {
    "abc", "123", "12a", "13464", "a13"
    };
    List<string> correto = new List<string>()
    {
    "123", "13464"
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
        SceneManager.LoadScene("Nivel5");
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Nivel2"));
    }
    }
}