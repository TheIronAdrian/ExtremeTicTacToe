using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Undoing : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public Winning wins;
    private int i;
    private void OnMouseDown()
    {
        if (XOPress.counter > 0 && XOPress.end == 0 && XOPress.nlength>=0)
        {
            wins.matrix[(XOPress.lastname[XOPress.nlength][1]-'0'-1)*3 + (XOPress.lastname[XOPress.nlength][3]-'0'-1)].text=" ";
            XOPress.counter--;
            XOPress.nlength--;
            for (i = 0; i < 9; i++)
            {
                if (wins.matrix[i].text == "?")
                {
                    wins.matrix[i].text = " ";
                }
                wins.matrix[i].color = Color.black;
            }
            Hinter.Hintus = 0;
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
