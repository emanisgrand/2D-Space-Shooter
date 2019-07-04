using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowScript : MonoBehaviour
{
    private GameObject theShip;
    private float camToShipDistance;

    // Start is called before the first frame update
    void Awake()
    {
        if (theShip == null){
            theShip = GameObject.FindWithTag("Player");
        }    
    }

    // Update is called once per frame
    void Update()
    {
        if (theShip == null) { theShip = GameObject.FindWithTag("Player");}
        if (theShip != null){
            camToShipDistance = Vector2.Distance(transform.position,theShip.transform.position);

            transform.position = Vector2.Lerp(transform.position, theShip.transform.position, camToShipDistance * Time.deltaTime);
        }
    }
}
