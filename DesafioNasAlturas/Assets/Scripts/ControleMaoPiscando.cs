using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleMaoPiscando : MonoBehaviour
{
    private SpriteRenderer imagem;
    // Start is called before the first frame update
    private void Awake()
    {
        imagem = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Desaparecer();
        }
    }

    private void Desaparecer()
    {
        imagem.enabled = false;
    }
}
