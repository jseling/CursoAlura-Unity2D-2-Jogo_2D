using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerarFacil;

    [SerializeField]
    private float tempoParaGerarDificil;

    private float cronometro;

    [SerializeField]
    private GameObject obstaculoPrefab;

    private ControleDificuldade controleDificuldade;

    // Start is called before the first frame update
    void Awake()
    {
        cronometro = tempoParaGerarFacil;
    }

    private void Start()
    {
        controleDificuldade = GameObject.FindObjectOfType<ControleDificuldade>();
    }

    // Update is called once per frame
    void Update()
    {
        cronometro -= Time.deltaTime;
        if(cronometro <= 0)
        {
            Instantiate(obstaculoPrefab, transform.position, Quaternion.identity);
            cronometro = Mathf.Lerp(tempoParaGerarFacil, tempoParaGerarDificil, controleDificuldade.Dificuldade);
        }
    }
}
