using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Winning : MonoBehaviour
{
    public Score scoreBoard;
    public  TMP_Text[] matrix;
    public static string Wins="o";
    private int i;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (XOPress.end == 0)
        {

            for (i = 0; i < 9; i += 3)
            {
                if (matrix[i].text== matrix[i+1].text && matrix[i+2].text == matrix[i].text && matrix[i].text != " ")
                {
                    Wins = matrix[i].text;
                    matrix[i].color = Color.green;
                    matrix[i+1].color = Color.green;
                    matrix[i+2].color = Color.green;
                }
            }
            for (i = 0; i < 3; i ++)
            {
                if (matrix[i].text == matrix[i + 3].text && matrix[i + 6].text == matrix[i].text && matrix[i].text != " ")
                {
                    Wins = matrix[i].text;
                    matrix[i].color = Color.green;
                    matrix[i + 3].color = Color.green;
                    matrix[i + 6].color = Color.green;
                }
            }
            if (matrix[0].text == matrix[4].text && matrix[8].text == matrix[0].text && matrix[0].text != " ")
            {
                Wins = matrix[0].text;
                matrix[0].color = Color.green;
                matrix[4].color = Color.green;
                matrix[8].color = Color.green;
            }
            if (matrix[2].text == matrix[4].text && matrix[6].text == matrix[2].text && matrix[2].text != " ")
            {
                Wins = matrix[2].text;
                matrix[2].color = Color.green;
                matrix[4].color = Color.green;
                matrix[6].color = Color.green;
            }
            if (Wins == "X" || Wins == "O")
            {
                GetComponent<TMP_Text>().text = Wins + " WON";
                if (Wins == "X")
                {
                    scoreBoard.X = scoreBoard.X + 1;
                }
                else
                {
                    scoreBoard.Y = scoreBoard.Y + 1;
                }
                XOPress.end = 1;
            }
            else
            {
                if (XOPress.counter-XOPress.starter==9)
                {
                    GetComponent<TMP_Text>().text ="DRAW";
                    XOPress.end = 1;
                }
                else
                {
                    GetComponent<TMP_Text>().text = " ";
                }
            }
        }
    }
}
