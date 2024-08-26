using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using UnityEngine.SceneManager
public class Player : MonoBehaviour
{
    public int velocidade = 10; 
    Rigidbody rb;
   
    void Start()
    {
        TryGetComponent(out rb);
    }

   
    void Update()
    {   Debug.Log(message"update");
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);

        if(transform.position.y <= -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
