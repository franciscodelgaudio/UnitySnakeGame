using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    public TextMeshProUGUI pontuacao;
    public GameObject snakeHead;
    private GrowSnake growSnake;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        growSnake = snakeHead.GetComponent<GrowSnake>();
        pontuacao.text = "Pontos: " + growSnake.newSnakeTailClone.Count;
    }
}
