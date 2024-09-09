using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveFoward : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=38.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //moves object foward
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }
}
