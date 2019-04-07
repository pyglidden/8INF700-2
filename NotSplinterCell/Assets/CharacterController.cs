using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterController : MonoBehaviour
{
    [SerializeField] private float velocity;
    Rigidbody rb;
    public static float globalSpeed =1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }

    void Moving(Vector3 myMove)
    {
        rb.MovePosition(transform.position + myMove* globalSpeed);
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
