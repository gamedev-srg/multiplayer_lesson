using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    float score = 1.0f;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + " Points";
    }

    public void addPoints()
    {
        score *= (1 + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

