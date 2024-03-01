using TMPro;
using UnityEngine;

namespace Script
{
    public class ScoreUI : MonoBehaviour
    {
        public TMP_Text scoreText;
	
        // reference ke score manager
        public ScoreManage scoreManager;

        private void Update()
        {
            // agar lebih mudah, tiap update kita set aja angak score text nya menjadi angka score
            scoreText.text = scoreManager.score.ToString();
        }
    }
}
