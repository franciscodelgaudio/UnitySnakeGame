using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject snakeHead;
    public GameObject canvas;
    private SnakeMove snakeMove;
    private GrowSnake growSnake;

    void Start (){
        canvas.SetActive(false);
    }
    
    void Update (){
        snakeMove = snakeHead.GetComponent<SnakeMove>();
        growSnake = snakeHead.GetComponent<GrowSnake>();
        for (int i = 1 ; i < growSnake.newSnakeTailClone.Count ; i++){
            if (snakeHead.transform.position == growSnake.newSnakeTailClone[i].transform.position){
                gameOver();
            }
        }
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
