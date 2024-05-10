using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowSnake : MonoBehaviour
{
    public GameObject snakeHead;
    public GameObject snakeTail;
    private SpawnApple spawnApple;
    private SnakeMove snakeMove;
    private GameObject snakeTailClone;

    private float moveTimer = 0;
    private float speed = 0.3f;

    public List<GameObject> newSnakeTailClone = new List<GameObject>();
    private bool start = false;

    void Update (){
        int i = 0;
        spawnApple = snakeHead.GetComponent<SpawnApple>();
        if(spawnApple.comeuMaca && newSnakeTailClone.Count == 0){
            newSnakeTailClone.Add(Instantiate(snakeTail, snakeHead.transform.position, Quaternion.identity));
            start = true;
        }
        else if (spawnApple.comeuMaca){
            newSnakeTailClone.Add(Instantiate(snakeTail, newSnakeTailClone[i].transform.position, Quaternion.identity));
            start = true;
            i++;
        }
        if (start){MoveClone();}
    }

    void MoveClone (){
        moveTimer += Time.deltaTime;
        if (moveTimer >= speed){
            for (int i = newSnakeTailClone.Count-1; i > 0; i--){
                newSnakeTailClone[i].transform.position = newSnakeTailClone[i-1].transform.position;
            }
            newSnakeTailClone[0].transform.position = snakeHead.transform.position; 
            moveTimer = 0;
        }
    }
}
