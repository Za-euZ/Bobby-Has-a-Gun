using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    public static GameManagerScript instance = null;

    public GameObject youWinText;

    void Awake() {
        if (instance == null) {
            instance = this;
        } 
        else if (instance != null) {
            Destroy(gameObject);
        }
        

    }

    public void Win() {

        youWinText.SetActive(true);
        Time.timeScale = 0f;

    }
}
