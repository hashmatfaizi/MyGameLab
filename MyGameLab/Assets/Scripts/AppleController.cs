using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleController : MonoBehaviour {
    // Update is called once per frame
    void Update() {
        if (gameObject.transform.position.x > 9.25f || gameObject.transform.position.x < -9.25f) {
            Destroy(gameObject);
        }
    }
}
