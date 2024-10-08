using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Observer
{
    public class ScoreManager : Observer
    {
        private int _score;
        private PlayerController _player;

        void OnGUI()
        {
            GUILayout.BeginArea(
            new Rect(950, 100, 300, 300));
            GUILayout.BeginHorizontal("Score");
            GUILayout.Label ("Score: " + _score);
            GUILayout.EndHorizontal ();
            GUILayout.EndArea();
        
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void Notify(Subject subject)
        {
            _score = _player.score;
        }
    }
}
