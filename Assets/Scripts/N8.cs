using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class N8 : MonoBehaviour
{
    private bool con;
    private string pattern;
    public GameObject inputField; 
    public GameObject textHist;
    public Button btnNext;
    private List<string> historico = new List<string>();

    public void Main(){
        List<string> names = new List<string>(){"435-ABC", "D4DA-3355", "ABC-1234", "BDE.4356", "BLF-1233", "BFC-A123"};
        List<string> correto = new List<string>(){"ABC-1234", "BLF-1233"};
        List<string> resposta = new List<string>();

        pattern = inputField.GetComponent<Text>().text;

        historico.Add(pattern);

        foreach (string hist in historico){
            textHist.GetComponent<Text>().text = hist;
        }

        foreach (string name in names){
            if (Regex.IsMatch(name, pattern)){
                resposta.Add(name);
            }
        }

        con = resposta.SequenceEqual(correto);
        
        if(con == false){
            textHist.GetComponent<Text>().color = Color.red;
            btnNext.interactable = false;
        }else{
            textHist.GetComponent<Text>().color = Color.green;
            btnNext.interactable = true;
        }
    }
}