using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class degueulasse : MonoBehaviour
{
    public GameObject Player;
    void OnTriggerEnter(Collider other) {
        if(other.gameObject == Player)
        other.transform.parent = transform;
    }
    void OnTriggerExit(Collider other) {
        if (other.gameObject == Player)
            other.transform.parent = null;
    }
}
