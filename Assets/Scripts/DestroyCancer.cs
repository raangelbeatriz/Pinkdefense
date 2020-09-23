using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyCancer : MonoBehaviour
{
    //public static int pontosBatalha = 0;
    public Text Pontuacao;
    public Vidas Vidas;
    private SomManagement SomManagement;
    // Start is called before the first frame update
    void Start()
    {
       Vidas = FindObjectOfType(typeof(Vidas)) as Vidas;
       SomManagement = FindObjectOfType(typeof(SomManagement)) as SomManagement;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destruir()
    {
        SomManagement.TocarSom(SomManagement.matarTumor);
        Vidas.SetPontucao();
        GameObject cancer = this.gameObject;
        Destroy(cancer);
        

    }
}
