using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 7;
    private bool noChao;
    Rigidbody rb;

    private AudioSource source;
   
    void Start()
    {
        TryGetComponent(out rb);

        TryGetComponent(out source);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!noChao && collision.gameObject.tag == "Chão")
        {
            noChao = true;
        }
    }

    void Update()
    {   
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            source.Play();
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
            noChao = false;
        }
        
        
        
        if(transform.position.y <= -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
