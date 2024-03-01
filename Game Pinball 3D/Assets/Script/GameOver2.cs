using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Script
{
    public class GameOver2 : MonoBehaviour
    {
// reference untuk button
        public Button mainMenuButton;

        private void Start()
        {
            // setup event saat button di klik
            mainMenuButton.onClick.AddListener(MainMenu);
        }

        public void MainMenu()
        {
            // kembali ke main menu
            SceneManager.LoadScene("MainMenu");
        }
    }
}
