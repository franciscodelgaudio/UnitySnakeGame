using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnApple : MonoBehaviour
{
    public GameObject snakeHead;
    public GameObject apple;
    public bool comeuMaca;
    private GameObject newApple;

    private GrowSnake growSnake;
    void Awake()
    {
        newApple = Instantiate (apple, new Vector3 (1, 0, 0), Quaternion.identity);
    }

    void Update (){
        comeuMaca = (snakeHead.transform.position == newApple.transform.position);

        growSnake = snakeHead.GetComponent<GrowSnake>();
        bool appleSpawn = false;

        if(comeuMaca)
        {
            while (!appleSpawn){
                Vector3 newApplePosition = new Vector3(Random.Range(-6, 6), Random.Range(-4, 4), 0);
                if (spawnNewApple(newApplePosition)){
                    continue;
                }
                else{
                    Destroy(newApple);
                    newApple = Instantiate(apple, newApplePosition, Quaternion.identity);
                    appleSpawn = true;
                }
            }
        }
    }

    bool spawnNewApple(Vector3 newApplePosition){
        for (int i = 0 ; i < growSnake.newSnakeTailClone.Count ; i++){
            if (newApplePosition == growSnake.newSnakeTailClone[i].transform.position){
                return true;
            }
        }
        return false;
    }

}
