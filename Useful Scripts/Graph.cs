using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab;
    // Start is called before the first frame update
    void Awake()
    {
        var resolution = 50;
        float step = 2f / resolution;   

		var scale = Vector3.one / 5f;
		for (int i = 0; i < resolution; i++) {
            Transform point = Instantiate(pointPrefab);
            var x=((i + 1f) / resolution - 0.5f);
            var y= x*x*x;
            Vector3 position = Vector3.zero;
            position.x = x;
            position.y = y;
            point.localPosition = position;
			point.localScale = Vector3.one / resolution;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
