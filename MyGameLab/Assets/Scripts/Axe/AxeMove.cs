using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeMove : MonoBehaviour {
    private GameObject[] player;
    float speed = 0.7f;
    // Start is called before the first frame update
    void Start() {
        player = GameObject.FindGameObjectsWithTag("Player");
        
    }
    private void Update() {
        gameObject.transform.Translate(
            ((Vector2.down + Vector2.right) * speed * Time.deltaTime)); //player[0].transform.position - gameObject.transform.position).normalized
    }
}
