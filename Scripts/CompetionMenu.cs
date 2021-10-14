using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompetionMenu : MonoBehaviour {

    public void RestartLevel() {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");

    }

    public void MenuButton() {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }

}
