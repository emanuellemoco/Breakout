using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoRaquete : MonoBehaviour
{
    GameManager gm;
    [Range(1,10)] //variacao da velocidade
    public float velocidade;
    float cantoDireito = 7.88f;
    float cantoEquerdo = -7.88f;
    

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();  
        
    }


    void Update()
    {
    if (gm.gameState != GameManager.GameState.GAME) return;

    float inputX = Input.GetAxis("Horizontal");
    transform.position += new Vector3(inputX, 0, 0) * Time.deltaTime * velocidade;  

    if(Input.GetKeyDown(KeyCode.Escape) && gm.gameState == GameManager.GameState.GAME) {
        gm.ChangeState(GameManager.GameState.PAUSE);
    }

    // Para a raquete nao passar pelas bordas
    if (transform.position.x < cantoEquerdo){
        transform.position = new Vector2(cantoEquerdo, transform.position.y);
    }
    if (transform.position.x > cantoDireito){
        transform.position = new Vector2(cantoDireito, transform.position.y);
    }


    }

} 