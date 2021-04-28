using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    // ------   
    public Transform player;

    public Slider sliderLife;
    public GameObject panGameOver;
    public Text txtScoreGameOver;

    public GameObject Apple;
    public GameObject FlyingAxe;

    public static int Score { get; set; }
    public static float Life { get; set; }
    private bool GameOver;

    private float lifeSpeedLoss = 20f;


    // Start is called before the first frame update
    void Start() {
        GameOver = false;
        Score = 0;
        Life = 100f;
        StartCoroutine("AppleGeneration");
    }

    // Update is called once per frame
    private void FixedUpdate() {
        Life -= lifeSpeedLoss / 100f;
        if (Life > 100f) {
            Life = 100f;
        }
        GameIsOver();
    }
    private void Update() {
        sliderLife.value = Life / 100f;
    }
    private void GameIsOver() {
        if (Life < 0) {
            panGameOver.SetActive(true);
            GameOver = true;
            txtScoreGameOver.text = "Счет: " + Score.ToString();
            Time.timeScale = 0;
            if (PlayerPrefs.HasKey("BestScore")) {
                if (Score > PlayerPrefs.GetInt("BestScore")) {
                    PlayerPrefs.SetInt("BestScore", Score);
                }
            }
            else {
                PlayerPrefs.SetInt("BestScore", Score);
            }
            PlayerPrefs.Save();
        }
    }

    private IEnumerator AppleGeneration() {
        while (GameOver == false) {
            Instantiate(Apple, new Vector3(Random.Range(-6.5f, 6.5f), 5.3f, 0), Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
        yield return null;
    }
}
