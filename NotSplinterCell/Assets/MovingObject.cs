using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public GameObject movingObject;
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
        movingObject = gameObject;


        if (myAxe == axis.x)
        {
            initialCoordonates = gameObject.transform.position.x;
            cumul = initialCoordonates;
        }
        else if (myAxe == axis.z)
        {
            initialCoordonates = gameObject.transform.position.z;
            cumul = initialCoordonates;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(myAxe == axis.x)
        {
            if(isPositive){
                movingObject.transform.Translate(new Vector3(manoeuvreMarge / 10f, 0, 0));
                cumul += manoeuvreMarge;
            }
            else
            {
                movingObject.transform.Translate(new Vector3(-manoeuvreMarge / 10f, 0, 0));
                cumul -= manoeuvreMarge;
            }

        }else if(myAxe == axis.z)
        {
            if (isPositive)
            {
                movingObject.transform.Translate(new Vector3(0, 0, manoeuvreMarge / 10f));
                cumul += manoeuvreMarge;
            }
            else
            {
                movingObject.transform.Translate(new Vector3(0, 0, -manoeuvreMarge / 10f));
                cumul -= manoeuvreMarge;
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
