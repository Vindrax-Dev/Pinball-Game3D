using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class GameOver : MonoBehaviour
    {
        public Collider bola;
        public GameObject gameOverCanvas;

        private void Start()
        {
            gameOverCanvas.SetActive(false);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other == bola)
            {
                //munculin canvas
                gameOverCanvas.SetActive(true);

            }
        }
    }
}
