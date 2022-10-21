using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleUIGameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;

    [SerializeField]
    private Text valorRecorde;

    private ControlePontuacao controlePontuacao;

    private int recorde;

    [SerializeField]
    private Image posicaoMedalha;

    [SerializeField]
    private Sprite medalhaOuro;

    [SerializeField]
    private Sprite medalhaPrata;

    [SerializeField]
    private Sprite medalhaBronze;


    // Start is called before the first frame update
    void Start()
    {
        controlePontuacao = GameObject.FindObjectOfType<ControlePontuacao>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AtualizarInterfaceGrafica()
    {
        recorde = PlayerPrefs.GetInt("recorde");
        valorRecorde.text = recorde.ToString();
    }

    public void MostrarInterface(bool habilitar)
    {
        if (habilitar)
        {
            AtualizarInterfaceGrafica();
            VerificarMedalha();
        };

        imagemGameOver.SetActive(habilitar);
    }

    private void VerificarMedalha()
    {
        if (controlePontuacao.Pontos == recorde)
        {
            posicaoMedalha.sprite = medalhaOuro;
        }
        else if (controlePontuacao.Pontos >  recorde - 10)
        {
            posicaoMedalha.sprite = medalhaPrata;
        }
        else
        {
            posicaoMedalha.sprite = medalhaBronze;
        }
    }
}
