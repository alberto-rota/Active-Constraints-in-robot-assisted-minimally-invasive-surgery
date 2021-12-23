using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using static UnityEngine.Mathf;

public class ForceComputation : MonoBehaviour
{

    [SerializeField]
    Transform endEffector;


    Vector3 velocity, deviation, force, normalizedVel, normalizedDev, fdirection;
    [SerializeField]
    static float B = 5;
    [SerializeField]
    static float Dm = 500;
    [SerializeField]
    static float F = 10;
    float fmagnitude, bk, Bprimo, theta;

    void Start()
    {
        
    }

    void Update()
    {

        velocity = ObjectVelocity.velocity;
        deviation = RobotPointDistance.d;

        normalizedVel = velocity/velocity.magnitude;
        if (velocity.magnitude == 0)
        {
            normalizedVel = Vector3.zero;
        }
        normalizedDev = deviation/deviation.magnitude;

        Vector3 n = Vector3.Cross(normalizedVel, normalizedDev);
        Debug.DrawLine(endEffector.position, (endEffector.position + n*2), Color.white);
        Debug.DrawLine(endEffector.position, (endEffector.position + velocity/3), Color.green);
        Debug.DrawLine(endEffector.position, (endEffector.position + normalizedDev), Color.blue);
        float dotProduct = Vector3.Dot(normalizedVel, normalizedDev);
        bk = B * Sqrt((1 - dotProduct) / 2);

        Bprimo = B;
        if (deviation.magnitude < Dm)
        {
            Bprimo = B * (deviation.magnitude) / Dm;
        }

        fmagnitude = F;
        if (bk*velocity.magnitude <= F)
        {
            fmagnitude = bk * velocity.magnitude;
        }

        fdirection = normalizedDev;
        if (dotProduct>=0)
        {
            float theta = (1 + dotProduct) * PI / 2 *180f/PI;
            fdirection = Quaternion.AngleAxis(theta, n) * normalizedVel;
        }

        force = fdirection * fmagnitude;
        Debug.Log(dotProduct);


        Debug.DrawLine(endEffector.position, (endEffector.position + force/5), Color.red);


    }
}