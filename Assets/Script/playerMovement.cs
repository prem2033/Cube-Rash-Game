using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rigidbody;
    public float forwardforce=100f;
    public float sidewaysForce=5f;
    void Start()
    {
       //rigidbody.useGravity=false;
       

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(0,0,forwardforce* Time.deltaTime);//if 10 frame the value ==0.1 if 20 then 0.2
        if(Input.GetKey("d") ){
            rigidbody.AddForce(sidewaysForce* Time.deltaTime,0,0,ForceMode.VelocityChange);//if 10 frame the value ==0.1 if 20 then 0.2
        }
        if(Input.GetKey("a") ){
            rigidbody.AddForce(-sidewaysForce* Time.deltaTime,0,0,ForceMode.VelocityChange);//if 10 frame the value ==0.1 if 20 then 0.2
        }
    }
}
