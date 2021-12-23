using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotPointDistance : MonoBehaviour
{
    [SerializeField] //nb: the transform attribute is not accessible from the external scripts by default, so we make it so by adding this line right before using it
    Transform RobotEndEffector;
    [SerializeField] 
    Transform path; //declaration of the variables that are associated to the transform of the point of the path and the end effector
    List<Transform> points=new List<Transform>();
    //creating the array of points
    public Camera cam; //declaration of the type camera associated to the camera that will be used to play tha GUI, in this way the program knows where to put the points labels
    public static Vector3 d;
    Vector3 deviation; //vector used to store the deviation
    Vector3 pointGUI;  //vecotor used to store the point position in the gui
    Vector3 nearPoint; //this variable saves the path closest point to the end effector coordinates
    float devLength;   //variable to store the deviation magnitude
    float minDistance; //variable to store the minimum deviation magnitude
    Vector3 dNormalized; //variable that stores the endPoint of the deviation vecotr normalized (the starting point id the endeffector)

    // Start is called before the first frame update
    void Start()
    {
      foreach (Transform child in path)
      {
        points.Add(child.transform);
      }
    }

    // Update is called once per frame
    void Update()
    {
      //initialization of the variables for the closest point research
      deviation = points[0].position - RobotEndEffector.position; // we initialize the first distance vector 
      minDistance = deviation.magnitude;                          // i take the first point distance as the smallest one, it will be compared with the others later
      nearPoint = points[0].position;                       // i define nearPoint as the first point
      
      //closest point research
      for (int i = 1; i < points.Count; i++)
      {
          Vector3 deviation = points[i].position - RobotEndEffector.position; //computing the distance from the point i-th
          devLength = deviation.magnitude;                                    //computing the length of the distance vector
          if(devLength < minDistance){
            minDistance = devLength;                                    //if it is smaller than the smallest i label it as the smallest
            nearPoint = points[i].position;
          }
      }

      d = nearPoint - RobotEndEffector.position  ;
      //dNormalized = RobotEndEffector.position - d/ minDistance; //normalization of the vector
      //Debug.DrawLine(dNormalized, RobotEndEffector.position, Color.white);                            //printing the deviation vecotor d in 
        
    }
    void OnGUI()
       {
          pointGUI = cam.WorldToScreenPoint(RobotEndEffector.position); //computing the GUI position of the point
          // GUI.Label(new Rect(pointGUI.x, ((270 - pointGUI.y)+10), 20, 20), minDistance.ToString()); //placing the lable indicating the distance on the GUI position
       }
}
