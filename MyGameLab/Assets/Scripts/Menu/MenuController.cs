using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    public Text txtBestScore;

    private void Start() {
        if (PlayerPrefs.HasKey("BestScore")) {
            txtBestScore.text = "Лучший счет: " + PlayerPrefs.GetInt("BestScore").ToString();
        }
    }

    public void BtnPlayIsClicked() {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }


}
