using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChanger : MonoBehaviour
{
    [SerializeField] float time, hero, objectS;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TimeScale Modified by Patate");
        Time.timeScale = time;
        MovingObject.globalSpeed = objectS;
        CharacterController.globalSpeed = hero;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
