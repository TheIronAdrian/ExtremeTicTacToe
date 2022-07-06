using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int X=0;
    public int Y=0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (XOPress.counter % 2  == 0)
        {
            GetComponent<TMP_Text>().text = "-ScoreBoard-\n>>Player X :"+X+"\n   Player O :"+Y;
        }
        else
        {
            GetComponent<TMP_Text>().text = "-ScoreBoard-\n   Player X :" + X + "\n>>Player O :"+Y;
        }
    }
}
