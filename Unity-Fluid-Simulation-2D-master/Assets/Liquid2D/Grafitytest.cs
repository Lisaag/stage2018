using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector2Extension
{
    public static Vector2 Rotate(this Vector2 v, float degrees)
    {
        float grav = 9.8f;

        float radians = degrees * Mathf.Deg2Rad;
        float sin = Mathf.Sin(radians);
        float cos = Mathf.Cos(radians);

        float tx = v.x;
        float ty = v.y;

        return new Vector2((cos * tx - sin * ty) * -grav, (sin * tx + cos * ty) * grav);
    }
}


public class Grafitytest : MonoBehaviour
{

    float maxGrav = 9.8f;
    float gravY = -9.8f;
    float gravX;
    int xFact = 1;
    int yFact = 1;
    float rotSpd = 0.2f;

    public float max = 360, min = -360, scale = 9.8f;

    float currentGravX;
    float currentGravY;

    public Rigidbody2D waterRb;

    Vector3 dir = Vector3.zero;
    public Gyroscope acc;
    float dirX;

    Vector2 direction;


    void Start()
    {
        Physics2D.gravity = new Vector2(0, gravY);

        Input.gyro.enabled = true;
        acc = Input.gyro;
        Debug.Log(Physics2D.gravity);

    }

    void Update()
    {
        Acc();
        Physics2D.gravity = Vector2.right.Rotate(transform.eulerAngles.z);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //waterRb.velocity = new Vector2(0, 100);
            //waterRb.AddForce(new Vector2(0, 100), 0);
        }

        if (Input.anyKey)
        {
            ShakePhone();
            RotatePhone();
        }

        //Screen.orientation

    }

    void ShakePhone()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Physics2D.gravity = Vector2.right * gravY;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Physics2D.gravity = Vector2.left * gravY;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Physics2D.gravity = Vector2.down * gravY;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Physics2D.gravity = Vector2.up * gravY;
        }

        /* if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
         {
             currentGravX = Physics2D.gravity.x;
             currentGravY = Physics2D.gravity.y;
             Physics2D.gravity = new Vector2((currentGravX *= -1), currentGravY);
         }

         if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
         {
             currentGravX = Physics2D.gravity.x;
             currentGravY = Physics2D.gravity.y;
             Physics2D.gravity = new Vector2(currentGravX, (currentGravY *= -1));
         }*/


    }

    void RotatePhone()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Physics2D.gravity -= new Vector2((rotSpd * xFact), (rotSpd * yFact));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Physics2D.gravity -= new Vector2((rotSpd * -xFact), (rotSpd * -yFact));
        }

        if (Physics2D.gravity.x < gravY || Physics2D.gravity.x > -gravY)
        {
            //if transform.rotate.z < 0;
            xFact *= -1;
        }
        if (Physics2D.gravity.y < gravY || Physics2D.gravity.y > -gravY)
        {
            yFact *= -1;
        }

    }

    void Acc()
    {
        dirX = (int)(Input.acceleration.x * 20);
        // Debug.Log(Input.acceleration);
        acc = Input.gyro;
       // transform.rotation = acc.attitude;
        
        
        
        
        
        //Physics2D.gravity = new Vector2();

       ////// Physics2D.gravity = new Vector2(((transform.eulerAngles.z / 10) * xFact) * scale, -9.8f);
       

       //Physics2D.gravity = new Vector2(-9.8f, ((transform.eulerAngles.z / 10) * -xFact) * scale);
      




        //Physics2D.gravity = new Vector2(((transform.eulerAngles.z - min) / (max - min)) * scale, ((transform.eulerAngles.y - min) / (max - min)) * scale);
        //van -1, 1, min & max naar 90
        //(transform.eulerAngles.z- min) / ( max - min)

    }

}
