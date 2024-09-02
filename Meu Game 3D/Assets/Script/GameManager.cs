using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI HUD, Vitoria;

    public int restantes;
    void Start()
    {
        restantes = FindObjectOfType<Moeda>().Length;

        HUD.text = $"Moedas restantes: {restantes}";

    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        HUD.text = $"Moedas restantes: {restantes}";

        if (restantes <= 0)
        {
            Vitoria.text = "Parabéns, você terminou a fase 1!";
        }
    }
    
    
    
    
    
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
