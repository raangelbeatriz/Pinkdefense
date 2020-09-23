using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    float positionX;
    float positionY;
    public GameObject Tumor;
    public GameObject Limit;
    public Transform ButParent;
    //public GameObject Center;
    int time;


  

    void Start()
    {
 

    }

    // Update is called once per frame
    void Update() //Timedeltatime
    {
        time++;

        if (time == 50)
        {
            Invocar();
            time = 0;
        } 


    }

    public void Invocar()
    {

        positionX = Random.Range(Limit.transform.localPosition.x, Limit.transform.localPosition.x*1.5f);
        positionY = Random.Range(Limit.transform.localPosition.y, Limit.transform.localPosition.y*1.5f);

        Vector2 mc = new Vector2(positionX, positionY);
        //Instantiate(Tumor, new Vector2(positionX, positionY), Quaternion.identity);
        if (Time.timeScale == 1){
            var butTumor = Instantiate<GameObject>(Tumor.gameObject, ButParent);
            butTumor.transform.position = mc; 
        }
            

        
        


        
    }
}
