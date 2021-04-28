using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // ForceOnClick() * установки процедуры
    private float forceFlightMultiplier = 100f; // множитель силы полета
    private float maxForce = 350f;  // макимальная сила


    // Update is called once per frame
    void FixedUpdate() {
        ForceOnClick();
    }



    // применить силу к игроку при клике
    private void ForceOnClick() {       
        
        if (Input.GetMouseButton(0)) {
            // определение координаты мыши
            Vector3 mouse = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                    Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
            // Рассчет силы
            Vector2 forceMath = (mouse - gameObject.transform.position) * forceFlightMultiplier;
            // Ограничение силы
            if (forceMath.x > maxForce) {
                forceMath.x = maxForce;
            }
            if (forceMath.x < -maxForce) {
                forceMath.x = -maxForce;
            }
            if (forceMath.y > maxForce) {
                forceMath.y = maxForce;
            }
            if (forceMath.y < -maxForce) {
                forceMath.y = -maxForce;
            }

            gameObject.transform.GetComponent<Rigidbody2D>().AddForce(forceMath);
            //Debug.Log(forceMath);
        }
    }
}
