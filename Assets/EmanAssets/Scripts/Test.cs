using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int health = 0;
    private bool highHealth = false;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        BugFuck();
    }

    void BugFuck()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health++;
            Debug.Log("My health is" + health);
        }

        if (health >= 5)
        {
            Debug.Log("I HAVE SO MUCH HEALTH!");
        }

        if (health == 10)
        {
            highHealth = true;
        }

        if (highHealth == true)
        {
            health = 0;
            Debug.Log("Resetting Health now!");
            highHealth = false;
        }
    }

}

