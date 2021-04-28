using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTriggers : MonoBehaviour {
    public GameObject panPause;
    private void Start() {
        panPause.SetActive(false);
    }
    public void BtnPauseIsClicked() {
        Time.timeScale = 0;
        panPause.SetActive(true);

    }
    public void BtnResumeIsClicked() {
        panPause.SetActive(false);
        Time.timeScale = 1;
    }
    public void BtnQuitIsClicked() {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void BtnNewGameIsClicked() {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
