using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{

    private Aviao aviao;
    private ControlePontuacao pontuacao;
    private ControleUIGameOver interfaceGameOver;
    private ControleDificuldade controleDificuldade;
    // Start is called before the first frame update
    private void Start()
    {
        aviao = GameObject.FindObjectOfType<Aviao>();
        pontuacao = GameObject.FindObjectOfType<ControlePontuacao>();
        interfaceGameOver = GameObject.FindObjectOfType<ControleUIGameOver>();
        controleDificuldade = GameObject.FindObjectOfType<ControleDificuldade>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        pontuacao.SalvarRecorde();
        interfaceGameOver.MostrarInterface(true);
    }

    public void ReiniciarJogo()
    {
        DestruirObstaculos();
        interfaceGameOver.MostrarInterface(false);
        Time.timeScale = 1;
        aviao.Reiniciar();
        pontuacao.Reiniciar();
        controleDificuldade.Reiniciar();
    }

    private void DestruirObstaculos()
    {
        ControlaObstaculo[] obstaculos = GameObject.FindObjectsOfType<ControlaObstaculo>();
        foreach(ControlaObstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
