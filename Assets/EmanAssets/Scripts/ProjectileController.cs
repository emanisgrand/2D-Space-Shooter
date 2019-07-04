using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    private ScoreHolder scoreHolderRef;

    void Awake() {
        scoreHolderRef = GameObject.FindWithTag("GameController").GetComponent<ScoreHolder>();    
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Enemy") {
            scoreHolderRef.IncreaseScore();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
