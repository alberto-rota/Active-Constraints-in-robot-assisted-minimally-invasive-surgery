using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVelocity : MonoBehaviour
{
 
    [SerializeField]
    Transform body;
    public static Vector3 velocity;
    Vector3 previous = new Vector3(0.0f,0.0f,0.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = (body.position - previous) / Time.deltaTime;
        previous = body.position;

        Vector3 velNormalised = velocity; // velocity.magnitude;
        Debug.DrawLine(body.position, (body.position + velNormalised), Color.green);
        //Debug.Log(velocity);
    }
}
