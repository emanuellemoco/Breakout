using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocoSpawner : MonoBehaviour
{
  public GameObject BlocoRoxo, BlocoVerde;
  GameManager gm;
  Bloco bloco; //?

  void Start()
  {
      gm = GameManager.GetInstance();
      GameManager.changeStateDelegate += Construir;
      Construir();
  }

  void Construir()
  {
      
       if (gm.gameState == GameManager.GameState.GAME)
      {
          foreach (Transform child in transform) {
              GameObject.Destroy(child.gameObject);
          }
          for(int i = 0; i < 10; i++)
          {
              for(int j = 0; j < 4; j++){
                  Vector3 posicao = new Vector3(-8f + 2f * i, 4f - 1f * j);
                int x = Random.Range(0,2);
                if(x == 0){
                    Instantiate(BlocoRoxo, posicao, Quaternion.identity, transform);
                }
                if(x == 1) { 
                    Instantiate(BlocoVerde, posicao, Quaternion.identity, transform);
                }
                  
  
              }
          }
      }
  }

  void Update()
  {
      //VOLTAR PARA 0
      //Quando os blocos acabam, o jogo entra no estado ENDGAME
      if (transform.childCount <= 0 && gm.gameState == GameManager.GameState.GAME)
      {
          gm.ChangeState(GameManager.GameState.ENDGAME);
          //RESETAR A POSICAO DA BOLA!!
      }
  }

}