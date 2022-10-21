using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaObstaculo : MonoBehaviour
{
    [SerializeField]
    private VariavelCompartilhadaFloat velocidade;

    [SerializeField]
    private float variacaoPosicaoY;

    private Vector3 posicaoAviao;

    private bool pontuei;

    private ControlePontuacao pontuacao;

    // Start is called before the first frame update
    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-variacaoPosicaoY, variacaoPosicaoY));
    }

    private void Start()
    {
        posicaoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        pontuacao = GameObject.FindObjectOfType<ControlePontuacao>();
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.left * velocidade.valor * Time.deltaTime);

        if (!pontuei && posicaoAviao.x > transform.position.x)
        {
            pontuei = true;
            pontuacao.AdicionarPontos();
        }
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        Destruir();
    }

    public void Destruir()
    {
        Destroy(gameObject);
    }
}
