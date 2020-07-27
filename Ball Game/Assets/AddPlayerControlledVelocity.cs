using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;

    // Update is called once per frame
    void Update()
    {
        if (Input.Getkey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3Force;
        if (Input.Getkey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force;
    }
}
