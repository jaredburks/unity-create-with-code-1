using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
//using static UnityEditor.Experimental.GraphView.Port;
using Color = UnityEngine.Color;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer; // Original code
    public Material material;

    public  Vector3 scaleChange;
    public float rotationSpeed; // = 10.0f;
    public float colorChangeRate = 0.01f;


    void Start()
    {
        transform.position = new Vector3(3, 4, 1); // Original code
        transform.localScale = Vector3.one * 1.3f; // Original code

        //Material material = Renderer.material; // Original code. Moved to change color of cube over time.
        //material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f); // Original code

        rotationSpeed = Random.Range(-10.0f, 10.0f); // Task #7 (Done)

    }

    private void Awake()
    {
        scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);

    }

    void Update()
    {

        // Tasks:
        // 1. Change the cube's location (transform). (Done)
        // 2. Change the cube's scale. (Done)
        // 3. Change the angle at which the cube rotates. (Done)
        // 4. Change the cube’s rotation speed. (Done)
        // 5. Change the cube’s material color. (Done)
        // 6. Change the cube’s material opacity. This is the 4th argument in Color(). (Done)
        // Bonus:
        // 7. Modify any of the changes above so they change randomly each time the scene is played. (Done)
        // 8. Change the color of the cube over time (Done)


        //Change the angle at which the cube rotates.
        //transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f); // Original code
        //Change the cube’s rotation speed.
        transform.Rotate(0.0f, 10.0f * Time.deltaTime * rotationSpeed, 0.0f);


        //Change the cube's location (transform).
        transform.Translate(1.0f * Time.deltaTime, 0.0f, 0.0f);


        //Change the cube's scale.
        //transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        transform.localScale -= scaleChange;


        //Change the cube’s material color.
        material = Renderer.material;
        //material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);// Original code
        colorChangeRate += colorChangeRate * Time.deltaTime; // Task #8 (Done)
        material.color = new Color(colorChangeRate, 5.0f, 0.9f, 0.1f); // My mod
    }
}
