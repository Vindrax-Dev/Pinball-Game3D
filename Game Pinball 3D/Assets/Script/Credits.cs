using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Script
{
    public class Credits : MonoBehaviour
    {
        public Button BackButtons;

        private void Start()
        {
            BackButtons.onClick.AddListener(LoadScene);

        }
        private void LoadScene()
        {
            SceneManager.LoadScene("MainMenu");
        }

    }
}
