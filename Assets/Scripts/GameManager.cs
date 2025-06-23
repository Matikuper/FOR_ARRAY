using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] carteles;
    public Renderer gameRenderer;
    public int randomCartelIndex;

    // Start is called before the first frame update
    void Start()
    {
        //invocar la activación random cada 2 segundos   
        InvokeRepeating(nameof(ActivateRandomElement), 0,2f);
    }

    //función que desactiva todos los elementos del array
    void DesactivateAll()
    {
        //for
        
    }

    //función que activa un elemento al azar del array
    //y desactiva todos los demás
    void ActivateRandomElement()
    {
        DesactivateAll();
        //activar elemento al azar
        randomCartelIndex = Random.Range(0, carteles.Length);
        gameRenderer.material.color = carteles[randomCartelIndex];
    }
}