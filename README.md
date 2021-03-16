# treinamento-unity-2

Código cubo


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    private Transform transformCubo;
    private Rigidbody rigidbodyCubo;
    private Vector3 velocidade1;

    private MeshCollider chao;
    // Start is called before the first frame update
    void Start()
    {
        
        rigidbodyCubo = GetComponent<Rigidbody>();
        velocidade1 = new Vector4(10f, 0, 0);
}

    // Update is called once per frame
    void Update()
    {
        rigidbodyCubo.AddForce(velocidade1*Time.deltaTime, ForceMode.VelocityChange);
    }
}





Código Bola




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




