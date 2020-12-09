using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    [HideInInspector]
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        textScore = textScore.GetComponent<TextMeshProUGUI>();
    }


    public void incrementScore()
    {
        score++;
        Debug.Log("Score: " + score);
        textScore.SetText("Score: " + score.ToString());
    }
}
