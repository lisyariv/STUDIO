using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 rightMovement;
    public Vector3 leftMovement;
    public Vector3 upMovement;
    public Vector3 downMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position += upMovement;
        }

        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position += leftMovement;
        }

        if(Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().position += downMovement;
        }

        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position += rightMovement;
        }
    }

}
