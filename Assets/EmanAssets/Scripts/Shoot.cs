using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Public Members
    public GameObject       laserPrefab;
    public Transform        launchLocation;
    public float            shootSpeed;
    public AudioSource      audioSource;
    public AudioClip        laserSound;
    //TODO:  public AudioClip[]      laserSounds; // sounds array.

    // Unity Attribute
    [Range(0.0f,1.0f)] 
    public float            laserVolume;
    
    // Private Member variables
    //private bool       isFiring =false;
    private GameObject projectileClone;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    
    private void FixedUpdate() {
        
    }

    public void Fire() {
        projectileClone = Instantiate(laserPrefab, launchLocation.position, transform.rotation);
        projectileClone.GetComponent<Rigidbody2D>().velocity = transform.up * shootSpeed;
        Destroy(projectileClone, 3.0f);
        audioSource.PlayOneShot(laserSound, laserVolume);
        
        // TODO: try to make it play random sounds
        // for (int i = 0; i < laserSounds.Length; i++)
        // {
        //     laserSounds = laserSounds[i];
        // }
        
    }

}