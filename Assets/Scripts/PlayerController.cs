using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Observer
{
    public class PlayerController : Subject
    {
        public int Score
        {
            get { return score; }
        }
        public ScoreManager score;

        void Awake()
        {
            score = gameObject.AddComponent<ScoreManager>();
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void AddScore(int amount)
        {
            score += amount;
            NotifyObservers();
        }//adds score and notify the observer to update
    }
}
