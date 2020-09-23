using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;




    void Start()
    {
        /*for(int i = 0; i <= 6; i++)
        {
            Invocar();
        }*/

        speed = 2;
        width = 14;
        height = 12;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;
        float x = Mathf.Cos(timeCounter) * width;
        float y = Mathf.Sin(timeCounter) * height;

        transform.position = new Vector3(x, y, 0);
    }

}
