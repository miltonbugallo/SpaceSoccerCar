using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    WheelJoint2D wheel1;
    WheelJoint2D wheel2;
    JointMotor2D motor;
    void Start()
    {
        wheel1 = gameObject.GetComponents<WheelJoint2D>()[0];
        wheel2 = gameObject.GetComponents<WheelJoint2D>()[1];
        motor = new JointMotor2D();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            motor.motorSpeed = -800;
            motor.maxMotorTorque = 1000;
            wheel1.useMotor = true;
            wheel1.motor = motor;
            wheel2.useMotor = true;
            wheel2.motor = motor;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            wheel1.useMotor = false;
            wheel2.useMotor = false;

        }
    }
}
