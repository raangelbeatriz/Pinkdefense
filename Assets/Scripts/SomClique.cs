using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomClique : MonoBehaviour
{
    SomManagement SomManagement;
    // Start is called before the first frame update
    void Start()
    {
        SomManagement = FindObjectOfType(typeof(SomManagement)) as SomManagement;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        SomManagement.TocarSom(SomManagement.fxClique);
    }
}
