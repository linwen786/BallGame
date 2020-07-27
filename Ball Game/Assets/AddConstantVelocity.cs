using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour

    
{
    [SerializeField]
    Vector3 v3Force;
    // Start is called before the first frame update(Executed once at beggining)
    void Start()
    {
         
    }

    // Update is called once per frame(executed every fps)
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += new Vector3(0.1f, 0, 0);
    }
}
