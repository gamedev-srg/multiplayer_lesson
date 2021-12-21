using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.MyCompany.MyGame
{
    public class PlayerScore : MonoBehaviour
    {
        public static PlayerScore instance;
        public Text scoreText;
        float score = 0.0f;

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
            score++;
            scoreText.text = score.ToString() + " Points";
        }

        void Update()
        {

        }

    }
}
