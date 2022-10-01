using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NelowGames;
using UnityEngine.SceneManagement;

namespace NelowGames {
    public class Menu : MonoBehaviour {
        public void Quit() {
            Application.Quit();
        }

        public void Retry() {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}