using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellor_rotation : MonoBehaviour
{
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate propellor.
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
