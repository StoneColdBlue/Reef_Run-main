using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PointsManager : MonoBehaviour
{

    public int score;
    public static PointsManager instan;

    public TextMeshProUGUI scoreText;

    public int value;

    public TextMeshProUGUI deathScore;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    private void Awake()
    {
        instan = this;
    }

    void triggBoss()
    {
        if (score == 50)
        {
            SceneManager.LoadScene(2);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        value = PlayerPrefs.GetInt("ScoreSave");
        deathScore.text = "Score: " + value;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("ScoreSave", score);
        triggBoss();
    }
}
