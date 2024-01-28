using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxeBox : MonoBehaviour
{
    public Transform destino; // Ponto para onde o objeto irá
    public float velocidade = 5f; // Velocidade do objeto
    public float tempoEspera = 3f; // Tempo em segundos para esperar no destino antes de retornar
    private float timer;
    private Vector3 posicaoOriginal;
    private bool movendoParaDestino = false;
    private bool movendoParaOrigem = false;


    void Start()
    {
        posicaoOriginal = transform.position;
        timer = tempoEspera;
    }

    void Update()
    {
        if (movendoParaOrigem) 
        {
            transform.position = Vector3.MoveTowards(transform.position, posicaoOriginal, velocidade * Time.deltaTime);
            if (transform.position == posicaoOriginal) 
            {
                movendoParaOrigem = false;
            }
        }

        if (!movendoParaDestino)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                movendoParaDestino = true;
            }
        }
        else
        {
            // Mover para o destino
            transform.position = Vector3.MoveTowards(transform.position, destino.position, velocidade * Time.deltaTime);

            // Verificar se o objeto alcançou o destino
            if (transform.position == destino.position)
            {
                // Esperar no destino por um tempo
                timer -= Time.deltaTime;

                if (timer <= 0f)
                {
                    // Inverter a direção (mover de ré)
                    movendoParaDestino = false;
                    movendoParaOrigem = true;
                    timer = tempoEspera; // Reiniciar o tempo de espera
                }
            }
        }
    }
}
