using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public Vector3 destination;
    public float rollingSpeed = 5f;
    private Rigidbody rb;
    public float despawnTime;
    private float timer;
    private void Awake()
    {
        destination = GameObject.Find("EndPoint").GetComponent<Transform>().position;
    }
    void Start()
    {
        // Obt�m o componente Rigidbody
        rb = GetComponent<Rigidbody>();

        // Chama o m�todo para iniciar o rolamento
       

        timer = despawnTime;
    }
    private void Update()
    {
        if (timer <= 0 || (Vector3.Distance(transform.position, destination) <= 2f))
        {
            Destroy(gameObject);
        }
        timer -= Time.deltaTime;
        RollToDestination();
    }

    void RollToDestination()
    {
        // Calcula a dire��o para o destino
        Vector3 direction = (destination - transform.position).normalized;

        // Aplica uma for�a para fazer o objeto rolar
        rb.AddForce(direction * rollingSpeed, ForceMode.Impulse);
        //Vector3.MoveTowards(transform.position, destination, rollingSpeed);
    }
}
