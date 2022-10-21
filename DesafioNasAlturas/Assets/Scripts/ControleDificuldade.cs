using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDificuldade : MonoBehaviour
{
    [SerializeField]
    private float tempoParaDificuldadeMaxima;

    private float tempoPassado;

    public float Dificuldade { get; private set;}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempoPassado += Time.deltaTime;
        Dificuldade = tempoPassado / tempoParaDificuldadeMaxima;
        Dificuldade = Mathf.Min(1, Dificuldade);
    }

    public void Reiniciar()
    {
        tempoPassado = 0;
        Dificuldade = 0;
    }
}
