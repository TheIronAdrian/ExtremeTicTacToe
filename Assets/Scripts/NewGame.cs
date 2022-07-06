using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewGame : MonoBehaviour
{
    public Winning wins;
    public int j;
       private void OnMouseDown()
    {
        if(XOPress.end !=0 )
        {
            XOPress.end = 0;
            XOPress.starter = 1 - XOPress.starter;
            XOPress.counter = XOPress.starter;
            for (j = 0; j < 9; j++)
            {
                wins.matrix[j].text = " ";
                wins.matrix[j].color = Color.black;
            }
            Winning.Wins = "";
            XOPress.nlength = -1;
            XOPress.time = 50;
        }
    }
    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = new Color32(68, 168, 50, 255);
    }
    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = new Color32(50, 227, 18, 255);
    }
}
