using UnityEngine;

namespace Script
{
    public class TrigerBonusScore : MonoBehaviour
    {
        public float score;

        public Collider bola;
        public ScoreManage scoreManager;

        private void OnTriggerEnter(Collider other)
        {
            if (other == bola)
            {
                //tambah skor kalau terkena bola
                scoreManager.AddScore(10000);
            }
        }
    }
}
