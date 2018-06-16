using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleCol : MonoBehaviour
{
   /* GameObject up;
    GameObject down;
    GameObject left;
    GameObject right;

    // Use this for initialization
    void Start()
    {
        up = GameObject.FindGameObjectWithTag("Up");
        down = GameObject.FindGameObjectWithTag("Down");
        left = GameObject.FindGameObjectWithTag("Left");
        right = GameObject.FindGameObjectWithTag("Right");


       Vector3 upPos = new Vector3((Camera.main.pixelWidth / 2), 0, 0);
        //up.transform.position = upPos;
        up.transform.position = Camera.main.ViewportToWorldPoint(upPos);
        Debug.Log(up.transform.position);

        //Debug.Log(Camera.main.ScreenToWorldPoint(new Vector3((Screen.width / 2), 0, 0)));



        //this.transform.localScale = new Vector3(Screen.width, 2, 2);



    }*/

    // Update is called once per frame
    void Update()
    {

        /*down.transform.position = Camera.main.ScreenToWorldPoint(new Vector2((Screen.width / 2), Screen.height));

        left.transform.position = Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height / 2));

        right.transform.position = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height / 2));*/
        /*if(this.transform.position.x < (this.transform.localScale.x / 2))
        {
            transform.position += new Vector3(1, 0, 0);
        }

        if (this.transform.position.x > (Screen.width - (this.transform.localScale.x / 2)))
        {
            transform.position -= new Vector3(1, 0, 0);
        }

        if (this.transform.position.y < (this.transform.localScale.y / 2))
        {
            transform.position += new Vector3(0, 1, 0);
        }

        if (this.transform.position.y > (Screen.height - (this.transform.localScale.y / 2)))
        {
            transform.position -= new Vector3(0, 1, 0);

        }*/
    }
}
