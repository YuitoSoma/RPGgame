using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreText : MonoBehaviour
{
    public Text bestScoreText;
    public static int bestnumber = 0;

    void Update()
    {
        if (bestnumber < EnemyManager.counter)
            bestnumber = EnemyManager.counter;
        bestScoreText.text = "BestScore : " + bestnumber;
    }
}