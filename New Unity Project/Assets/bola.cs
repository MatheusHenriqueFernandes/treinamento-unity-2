using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    private Transform transformBola;
    private Rigidbody rigidbodyBola;
    private Vector3 velocidade;

    private MeshCollider chao;
    // Start is called before the first frame update
    void Start()
    {

        rigidbodyBola = GetComponent<Rigidbody>();
        velocidade = new Vector3(-5f, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbodyBola.AddForce(velocidade*Time.deltaTime, ForceMode.VelocityChange);
    }
}
