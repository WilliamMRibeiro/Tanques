using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    
    public Text scoreText;//texto que vai informar os pontos para o jogador

    private int points;//isso é um campo ou membro da classe "scoremanager"

    public int Points //Propriedades é um tipo de variavel que encapsula um campo privado

    {
        get // Função Get
        {

            return points;

        }
        set // Função de retorno
        {
            points += value;//valor definido pela bala ao acertar o player

            UpdatePointsText();//chama a função de pontos

        }
    }
    private void Start()
    {
        scoreText.text = "Points: " + points.ToString();//define o valor de points no inicio do jogo
    }

    void UpdatePointsText()
    {
        scoreText.text = "Points: " + points.ToString();//atualiza o valor do score
    }
}
