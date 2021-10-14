using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool PauseCheck = false;

    public GameObject pauseMenuUi;

    void Update(){

        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (PauseCheck){

                Resume();

            }else{

                Pause();

            }

        }

    }

    public void Resume() {

        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        PauseCheck = false;

    }

    public void QuitGame() {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }

    public void RestartGame() {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");

    }

    void Pause() {

        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        PauseCheck = true;

    }

}
