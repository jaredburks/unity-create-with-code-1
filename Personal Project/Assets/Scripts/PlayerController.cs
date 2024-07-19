using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f;
    public float bumpForce = 0.01f;

    private Rigidbody playerRB;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();

    }

    // Moves the player based on wasd input.
    void MovePlayer()
    {
        // if press "w", move player forward.
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        // if press "a", move player left.
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        // if press "s", move player backwards.
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        // if press "d", move player right.
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }

    // Prevent the player from leaving the top, bottom, left, or right of the screen.
    void ConstrainPlayerPosition()
    {
        if (transform.position.x < -20)
        {
            playerRB.AddForce(Vector3.right * bumpForce, ForceMode.Impulse);
        }
        else if (transform.position.x > 20)
        {
            playerRB.AddForce(Vector3.left * bumpForce, ForceMode.Impulse);
        }
        else if (transform.position.z < -5)
        {
            playerRB.AddForce(Vector3.forward * bumpForce, ForceMode.Impulse);
        }
        else if (transform.position.z > 5)
        {
            playerRB.AddForce(Vector3.back * bumpForce, ForceMode.Impulse);
        }
    }

}
