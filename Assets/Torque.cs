using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour
{
    public HingeJoint joint;
    public float resitencia = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadActual = joint.velocity;
        float resistenciaTorque = -resitencia * velocidadActual;
        //GetComponent<Rigidbody>().AddTorque(0,1*resistenciaTorque,0);
    }
}
