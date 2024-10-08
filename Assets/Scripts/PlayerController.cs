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
        private ScoreManager score;

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

        public void AddScore()
        {
            score += 1;
            NotifyObservers();
        }
    }
}
