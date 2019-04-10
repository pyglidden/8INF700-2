using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public Rigidbody movingObject;
    public Vector3 direction;
    public float speed;
    public enum axis { x, z };
    public axis myAxe = axis.x;
    public static float globalSpeed;
    public bool isPlatform = false;
    public float initialCoordonates;
    public float manoeuvreMarge=0;
    bool isPositive = true;
    float cumul;
    // Start is called before the first frame update
    void Start()
    {
        movingObject = gameObject.GetComponent<Rigidbody>();


        if (myAxe == axis.x)
        {
       
            cumul = initialCoordonates;
        }
        else if (myAxe == axis.z)
        {
 
            cumul = initialCoordonates;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(myAxe == axis.x)
        {
            if(isPositive){
                movingObject.MovePosition(transform.position+new Vector3((manoeuvreMarge / 10f) * speed, 0, 0));
                cumul += (manoeuvreMarge / 10f) * speed;
            }
            else
            {
                movingObject.MovePosition(transform.position+new Vector3((-manoeuvreMarge/ 10f) * speed, 0, 0));
                cumul -= (manoeuvreMarge / 10f) * speed;
            }

        }else if(myAxe == axis.z)
        {
            if (isPositive)
            {
                movingObject.MovePosition(transform.position+new Vector3(0, 0,( manoeuvreMarge / 10f) * speed));
                cumul += (manoeuvreMarge / 10f) * speed;
            }
            else
            {
                movingObject.MovePosition(transform.position+new Vector3(0, 0, (-manoeuvreMarge / 10f)*speed));
                cumul -= (manoeuvreMarge / 10f) * speed;
            }
        }

        if(cumul >= initialCoordonates +manoeuvreMarge)
        {
            isPositive = false;
        }else if(cumul <= initialCoordonates-manoeuvreMarge)
        {
            isPositive = true;
        }
    }
}
