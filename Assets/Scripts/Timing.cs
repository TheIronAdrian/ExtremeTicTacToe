using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timing : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (XOPress.time > 0 && XOPress.end==0)
        {
             GetComponent<TMP_Text>().text ="Time Left:\n"+XOPress.time/10;
        }
        else
        {
            if (XOPress.counter % 2 == 0)
            {
                Winning.Wins = "O";
            }
            else
            {
                Winning.Wins = "X";
            }
            GetComponent<TMP_Text>().text = " ";
        }
    }
}
