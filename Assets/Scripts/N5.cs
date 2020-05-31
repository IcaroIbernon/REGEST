using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class N5 : MonoBehaviour
{
    private bool con;
    private string pattern;
    public GameObject inputField;
    public GameObject textHist;
    public Button btnNext;
    public AudioSource acerto;
    public AudioSource erro;
    private List<string> historico = new List<string>();

    public void ValidaPattern(bool btnAction)
    {
        if (btnAction)
        {
            List<string> names = new List<string>() { "fulano@asd.com", "fulano.com", "@fulano.com", "beltrano@bnn.com" };
            List<string> correto = new List<string>() { "fulano@asd.com", "beltrano@bnn.com" };
            List<string> resposta = new List<string>();

            pattern = inputField.GetComponent<Text>().text;

            historico.Add(pattern);

            foreach (string hist in historico)
            {
                textHist.GetComponent<Text>().text = hist;
            }

            foreach (string name in names)
            {
                if (Regex.IsMatch(name, pattern))
                {
                    resposta.Add(name);
                }
            }

            con = resposta.SequenceEqual(correto);

            if (con == false)
            {
                textHist.GetComponent<Text>().color = Color.red;
                erro.Play();
                btnNext.interactable = false;
            }
            else
            {
                textHist.GetComponent<Text>().color = Color.green;
                acerto.Play();
                btnNext.interactable = true;
            }
        }
    }
}