using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinter : MonoBehaviour
{
    // Start is called before the first frame update

    public Winning wins;
    private int i;
    public static int Hintus=0;

    private void OnMouseDown()
    {
        if (XOPress.end ==  0 && Hintus == 0)
        {
            do
            {
                i = Random.Range(0, 9); 
            }
            while (wins.matrix[i].text != " ");


            wins.matrix[i].color = Color.cyan;
            wins.matrix[i].text = "?";
            Hintus = 1;

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
