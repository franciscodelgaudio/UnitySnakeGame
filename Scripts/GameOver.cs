using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject snakeHead;
    public GameObject canvas;
    private SnakeMove snakeMove;

    void Start (){
        canvas.SetActive(false);
    }
    
    void Update (){
        snakeMove = snakeHead.GetComponent<SnakeMove>();
        if (snakeMove.limite){
            gameOver();
        }
    }

    void gameOver (){
        if (Time.timeScale == 1){
            Time.timeScale = 0;
            canvas.SetActive(true);
        }
    }
}
