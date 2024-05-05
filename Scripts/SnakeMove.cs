using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMove : MonoBehaviour
{
    private bool cima, baixo, esquerda, direita;
    private float moveTimer;
    public float speed = 0.3f;
    private Vector2Int snakePosition;
    public bool limite;

    void Awake (){
        snakePosition = new Vector2Int(0, 0);
    }

    void Update (){
        Move ();
        Limite ();
    }

void Move()
{
    // Detecta a tecla pressionada
    if (Input.GetKeyDown("up"))
    {
        if (!baixo)
        {
            cima = true;
            baixo = esquerda = direita = false;
        }
    }
    else if (Input.GetKeyDown("down"))
    {
        if (!cima)
        {
            baixo = true;
            cima = esquerda = direita = false;
        }
    }
    else if (Input.GetKeyDown("left"))
    {
        if (!direita)
        {
            esquerda = true;
            cima = baixo = direita = false;
        }
    }
    else if (Input.GetKeyDown("right"))
    {
        if (!esquerda)
        {
            direita = true;
            cima = baixo = esquerda = false;
        }
    }

    // Move o objeto com base na direção
    moveTimer += Time.deltaTime;
    if (moveTimer >= speed)
    {
        if (cima)
            snakePosition.y += 1;
        else if (baixo)
            snakePosition.y -= 1;
        else if (esquerda)
            snakePosition.x -= 1;
        else if (direita)
            snakePosition.x += 1;

        transform.position = new Vector3(snakePosition.x, snakePosition.y);
        moveTimer = 0;
    }
}

    void Limite (){
        limite = (transform.position.x > 7f || transform.position.x < -7f || transform.position.y > 5f || transform.position.y < -5f);
    }


}
