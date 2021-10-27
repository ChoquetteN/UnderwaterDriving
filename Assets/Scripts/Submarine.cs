using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine : MonoBehaviour
{


    float maxSpeed = 5f;
    float timeFromZeroToMax = 1.5f;
    float timeFromMaxToZero = 3f;
    float timeBreakToZero = 1.5f;

    float turnAnglePerSecond = 90f;
    float accelRatePerSec;
    float decelRatePerSec;
    float breakRatePerSec;
    float forwardVelocity;
    float rightVelocity;
    float upVelocity; 
    float currentTurn;


    Rigidbody rigidbody; 

    private void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        accelRatePerSec = maxSpeed / timeFromZeroToMax;
        decelRatePerSec = -maxSpeed / timeFromMaxToZero;
        breakRatePerSec = -maxSpeed / timeBreakToZero;
        forwardVelocity = 0;
        currentTurn = 0;

    }


    private void LateUpdate()
    {
        rigidbody.rotation = Quaternion.Euler(rigidbody.rotation.eulerAngles + new Vector3(0, currentTurn, 0));
        rigidbody.velocity = (transform.forward * forwardVelocity) + (transform.right * rightVelocity) + (transform.up * upVelocity);
        
        currentTurn = 0;

    }
  
    public void noInput()
    {

        forwardVelocity = Brake(decelRatePerSec, forwardVelocity);

        rightVelocity = Brake(decelRatePerSec, rightVelocity);

        upVelocity = Brake(decelRatePerSec, upVelocity);
    }

    public void SubMoveForward()
    {
       forwardVelocity = AccelerateInDirection(accelRatePerSec, forwardVelocity);
    }

    public void SubMoveBackward()
    {
       forwardVelocity = AccelerateInDirection(breakRatePerSec, forwardVelocity);
    }

    public void SubMoveLeft()
    {
        rightVelocity = AccelerateInDirection(breakRatePerSec, rightVelocity);
    }

    public void SubMoveRight()
    {
        rightVelocity = AccelerateInDirection(accelRatePerSec, rightVelocity);
    }

    public void SubMoveUp()
    {
        upVelocity = AccelerateInDirection(accelRatePerSec, upVelocity);
    }

    public void SubMoveDown()
    {
        upVelocity = AccelerateInDirection(breakRatePerSec, upVelocity);
    }

    float AccelerateInDirection(float accel, float direction)
    {
           direction += accel * Time.deltaTime;
           direction = Mathf.Clamp(direction, -maxSpeed , maxSpeed);

          return direction;
    }


    float Brake(float decel, float direction)
    {
        float reverseFactor = Mathf.Sign(direction);
        direction = Mathf.Abs(direction);
        direction += decel * Time.deltaTime;
        direction = Mathf.Max(direction, 0) * reverseFactor;
        return direction;
    }


    public void TurnSubLeft()
    {
        RotateSub(-1);
    }

    public void TurnSubRight()
    {
        RotateSub(1);
    }

    void RotateSub(int LeftOrRight)
    {
        currentTurn = turnAnglePerSecond * Time.deltaTime * LeftOrRight;
    }

}
