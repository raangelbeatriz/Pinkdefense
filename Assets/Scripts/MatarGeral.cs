using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatarGeral : MonoBehaviour
{
    public Button matarGeral;
    public GameObject[] Tumores;
    public bool podeDestruir = true;
    SomManagement somManagement;
    // Start is called before the first frame update
    void Start()
    {
        somManagement = FindObjectOfType(typeof(SomManagement))as SomManagement;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestruirGeral()
    {
        if(podeDestruir == true)
        {
            somManagement.TocarSom(somManagement.matarGeral);
            print("Entrou no destruir geral");
            Tumores = GameObject.FindGameObjectsWithTag("Cancer");

            foreach(GameObject Tumor in Tumores)
            {
                Destroy(Tumor.gameObject);
            }

            podeDestruir = false;
            matarGeral.interactable = false;
        }
        
    }
}
