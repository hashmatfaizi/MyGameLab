using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleDeleter : MonoBehaviour {
    public Text txtScore;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Apple") {
            Destroy(collision.gameObject);
            GameController.Score++;
            GameController.Life += 35f;
            txtScore.text = GameController.Score.ToString();
        }
    }
}
