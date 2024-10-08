using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Observer
{
    public class ScoreManager : Observer
    {
        public int _score;
        private PlayerController _player;

        void OnGUI()
        {
            GUILayout.BeginArea(
            new Rect(950, 100, 300, 300));
            GUILayout.BeginHorizontal("Score");
            GUILayout.Label ("Score: " + _score);
            GUILayout.EndHorizontal ();
            GUILayout.EndArea();
        
        }//show the player's current score and would update when being notify

        public override void Notify(Subject subject)
        {
            _score = _player.score;
        }
    }
}
