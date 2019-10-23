using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    private int points;//isso é um campo ou membro da classe "scoremanager"

    public int Points //Propriedades é um tipo de variavel que encapsula um campo privado

    {
        get // Função Get
        {

            return points;

        }
        set // Função de retorno
        {
            points += value;

            UpdatePointsText();

        }
    }
    private void Start()
    {
        scoreText.text = "Points: " + points.ToString();
    }

    void UpdatePointsText()
    {
        scoreText.text = "Points: " + points.ToString();
    }
}
