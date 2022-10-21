using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlePontuacao : MonoBehaviour
{
    public int Pontos { get; private set; }


    private Text textoPontuacao;

    private AudioSource audioPontuacao;

    private void Awake()
    {
        textoPontuacao = GetComponent<Text>();
        audioPontuacao = GetComponent<AudioSource>();
    }

    public void AdicionarPontos()
    {
        Pontos++;
        textoPontuacao.text = Pontos.ToString();
        audioPontuacao.Play();
    }

    public void Reiniciar()
    {
        Pontos = 0;
        textoPontuacao.text = Pontos.ToString();
    }

    public void SalvarRecorde()
    {
        if (Pontos > PlayerPrefs.GetInt("recorde"))
        {
            PlayerPrefs.SetInt("recorde", Pontos);
        }
    }
}
