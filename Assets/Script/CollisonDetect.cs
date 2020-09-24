using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class CollisonDetect : MonoBehaviour
{
    // Start is called before the first frame update
    public playerMovement movement;
    void OnCollisionEnter(Collision other) {
        if(other.collider.tag=="obstacle"){
        Debug.Log(other.collider.name);
            movement.enabled=false;
        }
    }
}
