using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour

{
    public int forcaTijolo, tipo;
    GameManager gm;
    public GameObject inteiro, quebrado;


    void Start(){

        gm = GameManager.GetInstance();   
        int x = Random.Range(0,3);
        quebrado.GetComponent<SpriteRenderer>().enabled = false;
        inteiro.GetComponent<SpriteRenderer>().enabled = true;
       
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (forcaTijolo == 1){
                Destroy(gameObject);
                gm.pontos++;
            }
            else {
                forcaTijolo -= 1;
            }

            if (forcaTijolo == 1){

                quebrado.GetComponent<SpriteRenderer>().enabled = true;
                inteiro.GetComponent<SpriteRenderer>().enabled = false;
                
            }
            if (forcaTijolo == 2){
                inteiro.GetComponent<SpriteRenderer>().enabled = true;
            }



            
    }
}

