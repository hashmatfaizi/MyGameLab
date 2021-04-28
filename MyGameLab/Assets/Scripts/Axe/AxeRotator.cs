using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeRotator : MonoBehaviour {

    // Update is called once per frame
    void FixedUpdate() {
        gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * 500);
    }
}
