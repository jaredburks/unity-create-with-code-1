using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;
    public GameObject player;
    private PlayerControllerX playerScript;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            //player = GameObject.FindWithTag("Player"); // This also works instead of line below.
            player = GameObject.Find("Player");
            playerScript = player.GetComponent<PlayerControllerX>();
            playerScript.dogExist = false;
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
