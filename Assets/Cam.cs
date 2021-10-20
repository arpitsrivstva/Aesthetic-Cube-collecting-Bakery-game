using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public float speed = 20f;
    public GameObject Cube;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-Input.GetAxis("Mouse Y")*Time.deltaTime*speed, 0, 0);
        Cube.transform.Rotate(0, Input.GetAxis("Mouse X")*Time.deltaTime*speed, 0);
    }
}
