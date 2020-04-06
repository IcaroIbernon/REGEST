using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class N3 : MonoBehaviour
{
    public bool con;
    public string pattern;
    public GameObject inputField; 
    public GameObject textDisplay;

    public void Main()
    {
    
    List<string> names = new List<string>()
    {
    "Alb.", "11al", "Alvaro", "Jorge.", "Ali2", "Alvin.23"
    };
    List<string> correto = new List<string>()
    {
    "Alb.", "Jorge."
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
        SceneManager.LoadScene("Nivel4");
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Nivel2"));
    }
    }
}