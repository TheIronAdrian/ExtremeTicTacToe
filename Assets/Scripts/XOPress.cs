using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class XOPress : MonoBehaviour
{
    // Start is called before the first frame update
    public static int counter;
    public static int starter=0;
    public static int end;
    public static int cordX;
    public static int cordY;
    public static string[] lastname = new string[20];
    public static int nlength=-1;
    public Winning wins;
    private int i;
    public static float time=50;

    private void Update()
    {
        if (end == 0)
        {
            time -= Time.deltaTime;
        }
    }

    private void OnMouseDown()
    {
        if (end == 0)
        {

            if (GetComponent<TMP_Text>().text!="X" && GetComponent<TMP_Text>().text != "O")
            {
                time = 50;
                for (i = 0; i < 9; i++)
                {
                    if (wins.matrix[i].text == "?")
                    {
                        wins.matrix[i].text = " ";
                    }
                    wins.matrix[i].color = Color.black;
                }
                Hinter.Hintus = 0;
                nlength++;
                lastname[nlength] = transform.name;
                if (counter%2 == 0)
                {
                    counter ++;
                    GetComponent<TMP_Text>().text = "X";
            
                }
                else
                {
                    counter ++;
                    GetComponent<TMP_Text>().text = "O";
                }
            }
        }
    }
}
