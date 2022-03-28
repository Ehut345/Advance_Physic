using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovemnet : MonoBehaviour
{
    float horizantalInput;
    float verticalInput;
    float steeringAngle;
    float motorTorque;
    public WheelCollider leftFrontWheelW;
    public WheelCollider rightFrontWheelW;
    public WheelCollider leftRareWheelW;
    public WheelCollider rightRareWheelW;
    public Transform leftFrontWheelT;
    public Transform rightFrontWheelT;
    public Transform leftRareWheelT;
    public Transform rightRareWheelT;
    public float maxSteeringAngle;
    public float maxMotorTorque;

    void Start()
    {

    }
    void FixedUpdate()
    {

    }

    void GetInput()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizantalInput = Input.GetAxis("Horizontal");
    }
    void Steer()
    {
        steeringAngle = maxSteeringAngle * horizantalInput;
        motorTorque = maxMotorTorque * verticalInput;
    }
    void Accelerate()
    {

    }
    void UpdateWheelPos()
    {

    }
    void UpdateWheelPos(WheelCollider wheelColl, Transform _transform)
    {

    }
}
