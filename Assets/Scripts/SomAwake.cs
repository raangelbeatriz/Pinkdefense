using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SomAwake : MonoBehaviour
{
    private SomAwake Instance;
    private void Awake()
    {
        if (Instance == null || ChangeScene.onBatalha == false)
        {
            DontDestroyOnLoad(this.gameObject);
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }



    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Instance != null && ChangeScene.onBatalha == true)
        {
            //print("onBatalha = " + ChangeScene.onBatalha); 
            Destroy(this.gameObject);
        }
    }

    
}
