using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameObject theShip;

    public GameObject asteroidSpawnerParent;

    private GameObject[] asteroidsToBeDestroyed;

    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Awake()
    {
        if(theShip == null){
            theShip = GameObject.FindWithTag("Player");
        }
        asteroidSpawnerParent.SetActive(true);
    }

    private void Start() {
        if (theShip != null){
            gameOverCanvas.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(theShip == null){
            gameOverCanvas.SetActive(true);
            Destroy(asteroidSpawnerParent);
            asteroidsToBeDestroyed = GameObject.FindGameObjectsWithTag("Enemy");
            
            //print(asteroidsToBeDestroyed.Length);

            for (int i = 0; i < asteroidsToBeDestroyed.Length; i++)
            {
              Destroy(asteroidsToBeDestroyed[i]);  
            }
        }
    }
}
