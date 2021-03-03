using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocoSpawner : MonoBehaviour
{
  public GameObject Bloco;
  //blocoAzul, etc...
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
          for(int i = 0; i < 11; i++)
          {
              for(int j = 0; j < 4; j++){
                  Vector3 posicao = new Vector3(-7.9f + 1.58f * i, 3.8f - 0.55f * j);

                  Instantiate(Bloco, posicao, Quaternion.identity, transform);
  
              }
          }
      }
  }

  void Update()
  {
      //VOLTAR PARA 0
      //Quando os blocos acabam, o jogo entra no estado ENDGAME
      if (transform.childCount <= 39 && gm.gameState == GameManager.GameState.GAME)
      {
          gm.ChangeState(GameManager.GameState.ENDGAME);
          //RESETAR A POSICAO DA BOLA!!
      }
  }

}