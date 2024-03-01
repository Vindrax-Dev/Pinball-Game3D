using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Script
{
    public class Menu : MonoBehaviour
    {
        public Button playButton;
        public Button exitButton;
        public Button creditButtons;
        private void Start()
        {
            playButton.onClick.AddListener(PlayGame);
            exitButton.onClick.AddListener(ExitGame);
            creditButtons.onClick.AddListener(Credits);
        }

        public void PlayGame()
        {
            SceneManager.LoadScene("MainScene");
        }
        private void ExitGame()
        {
            Application.Quit();
        }

        private void Credits()
        {
            SceneManager.LoadScene("CreditScene");
        }
    }
}