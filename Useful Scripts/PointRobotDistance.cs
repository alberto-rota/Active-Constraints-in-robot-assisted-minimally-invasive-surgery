using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointRobotDistance : MonoBehaviour
{
    [SerializeField] //nb: the transform attribute of clock is not accessible from the external scripts by default, so we make it so by adding this line right before using it
    Transform point, RobotEndEffector; //declaration of the variables that are associated to the transform of the point of the path and the end effector
    [SerializeField]
    public Camera cam; //declaration of the type camera associated to the camera that will be used to play tha GUI, in this way the program knows where to put the points labels
    Vector3 vec; //vector used to store the distance
    Vector3 p; //vecotor used to store the point position in the gui
    float vecLength; //vector to store the vec magnitude

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      Vector3 vec = point.position - RobotEndEffector.position; //computing the distance
      vecLength = vec.magnitude; //computing the length 
    }
    void OnGUI()
       {
          p = cam.WorldToScreenPoint(point.position); //computing the GUI position of the point
          GUI.Label(new Rect(p.x, ((270 - p.y)+10), 20, 20), vecLength.ToString()); //placing the lable indicating the distance on the GUI position
       }
}
