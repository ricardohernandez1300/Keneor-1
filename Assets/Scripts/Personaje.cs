using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    //Atributos del Jugador
    public string Nombre;
    public int Edad;
    public string Raza;
    public string Estado;
    public int HP = 20;
    public int Energía = 10;
    public int Mana = 10;
    public float probabilidadImpacto = .25f;
    public float probabilidadImpactoADistancia = .25f;
    public float probabilidadEvasion = .5f;
    public float escape = .25f;
    public float perseguir = .25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
