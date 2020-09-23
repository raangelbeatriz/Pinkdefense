using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCancer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    private GameObject cancer;
    float speed = 2.0F;
 
    void Start()
    {
        cancer = this.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        //cancer.transform.LookAt(target);


        //Vector2 relativePos = target.position - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        //Quaternion rotation = Quaternion.LookRotation(relativePos);

        //float rotationZ = Mathf.Atan2(relativePos.x,relativePos.y) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        Move();
         



    }

    private void Move()
    {
        speed = 2.0f + Vidas.PontoXtempo;
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

    }



}
