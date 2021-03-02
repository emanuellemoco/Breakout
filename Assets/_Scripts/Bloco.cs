using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour

{
    public int forcaTijolo;
    GameManager gm;

    Color newColor1 = new Color32(227, 197, 223, 255);  //light
    Color newColor2 = new Color32(154, 95, 179, 255);  //medium
    Color newColor3 = new Color32(154, 16, 225, 240);  //dark purple

    void Start(){

        gm = GameManager.GetInstance();   
        int x = Random.Range(0,3);


        if (x == 0){
            GetComponent<SpriteRenderer>().color = newColor1;
            forcaTijolo=1; 
        }
        if (x == 1){
            GetComponent<SpriteRenderer>().color = newColor2;
            forcaTijolo =2;
        }
        if (x == 2){
            GetComponent<SpriteRenderer>().color = newColor3;
            forcaTijolo=3;
        }
        
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
                GetComponent<SpriteRenderer>().color = newColor1;
            }
            if (forcaTijolo == 2){
                GetComponent<SpriteRenderer>().color = newColor2;
            }



            
    }
}

