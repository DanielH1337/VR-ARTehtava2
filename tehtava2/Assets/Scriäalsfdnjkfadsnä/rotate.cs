using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject cube;
    public float xAngle, yAngle, zAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
}
