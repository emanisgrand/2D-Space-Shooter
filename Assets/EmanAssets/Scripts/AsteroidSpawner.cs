using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroid;
    public float spawnDelay;

    private Vector2 randomVector2Direction;
    private GameObject asteroidClone;
    
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update(){
     
    }

    void Spawn()
    {
        randomVector2Direction = new Vector2(Random.Range(-1f,1f),Random.Range(-1f, 1f));
        float randomSpeed = Random.Range(1.0f,12f);

        asteroidClone = Instantiate(asteroid, transform.position, Quaternion.identity);
        asteroidClone.GetComponent<Rigidbody2D>().velocity = randomVector2Direction * randomSpeed;

        Invoke("Spawn", spawnDelay);
    }
}
