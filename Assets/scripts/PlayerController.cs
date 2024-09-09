using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update\
    public float horizontalInput;
    private float speed=30.0f;
    private float xRAnge = 23.0f;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //keeping plauer inbound
        if(transform.position.x<-xRAnge){
            transform.position=new Vector3(-xRAnge,transform.position.y,transform.position.z);
        }
            if(transform.position.x>xRAnge){
            transform.position=new Vector3(xRAnge,transform.position.y,transform.position.z);
        }
        //moving plauer side to side
        horizontalInput=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
        //shoot pizzas
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);
        }

    }
}
