using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterController : MonoBehaviour
{
    [SerializeField] private float velocity, myCameraSpeed, turnspeed;
    Rigidbody rb;
    [SerializeField] private GameObject dir;
    private Camera myCamera;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        myCamera = Camera.main;
    }

    void Moving(Vector3 myMove)
    {
        rb.MovePosition(transform.position + myMove);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") !=0)
        {
            Moving(new Vector3(Input.GetAxisRaw("Horizontal")*velocity, 0f, Input.GetAxisRaw("Vertical")*velocity));
        }


        
    }
}
