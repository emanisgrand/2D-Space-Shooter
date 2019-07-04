using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    private GameObject  theShip;
    private float asteroidToShipDistance;
    
    public float        destrcutionDistance;

    // Start is called before the first frame update
    void Start() {
        if (theShip == null)
        {
            theShip = GameObject.FindWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (theShip == null)
        {
            theShip = GameObject.FindWithTag("Player");
        }
        
        if (theShip != null){
        asteroidToShipDistance = Vector2.Distance(transform.position, theShip.transform.position);

        if (asteroidToShipDistance >= destrcutionDistance){
            Destroy(gameObject);
        }
    }
    }
}
