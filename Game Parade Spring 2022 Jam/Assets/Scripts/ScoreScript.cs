using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    public static float scoreValue = 0;
    public 
    Text score;
    public Text highScore;
    public GameObject VictoryScreen;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text> ();
        highScore.text = PlayerPrefs.GetFloat("HighScore: ", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Lives Saved: " + scoreValue;
        if (scoreValue > PlayerPrefs.GetFloat("HighScore: ", 0))
            {
            PlayerPrefs.SetFloat("HighScore: ", scoreValue);
            highScore.text = "HighScore: " + scoreValue.ToString();
            highScore.text = "HighScore: " + scoreValue;
        }
        if (scoreValue > 203)
        {
            VictoryScreen.SetActive(true);
            score.text = "";
        }
        
      
    }

}
