using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 Vec;
    //public Rigidbody RobotEndEffector;
    // Start is called before the first frame update
    void Start()
    {
        //RobotEndEffector = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vec = transform.localPosition;
        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 2;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 2;
        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 2;
        transform.localPosition = Vec;
        //Debug.Log(RobotEndEffector.velocity.magnitude);
    }
}