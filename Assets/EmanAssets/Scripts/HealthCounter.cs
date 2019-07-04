using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthCounter : MonoBehaviour
{

    public int health;
    public TextMeshProUGUI healthTextTMPro;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        // if (health <= 0){
        //     Destroy(gameObject);
        // }
           UpdateUI();
    }

    void UpdateUI(){
        healthTextTMPro.text = "Health: " + health.ToString();

    }

    private void OnCollisionEnter2D(Collision2D objectHit) {
        // Reference to the GameObject that was hit.
        GameObject obj = objectHit.gameObject;

        if(objectHit.gameObject.tag == "Enemy"){
            health--;
            UpdateUI();
            Destroy(obj);

            if(health<=0){
                Destroy(gameObject);
            }
        }
    }
}
