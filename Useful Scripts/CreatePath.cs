using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CreatePath : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab;
    [SerializeField]
    Transform path;
    void Awake()
    {
        var resolution = 500; // Number of points per meters
        float path_length = 3; 
        float step = 1f / resolution;   

		var scale = Vector3.one*0.2f;

		for (float i = 0; i < path_length; i+=step) {
            Transform point = Instantiate(pointPrefab);
            point.transform.parent = path.transform;
            float x = 5*i;
            float z = 3f*Mathf.Exp(-(x-2)*(x-2));
            float y = 0f;
            Vector3 position = Vector3.zero;
            position.x = x;
            position.y = y;
            position.z = z;
            point.localPosition = position;
			point.localScale = scale;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
