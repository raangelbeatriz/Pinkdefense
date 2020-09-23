using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cura : MonoBehaviour
{
    //public Button ButtonCura;
    private Vidas Vidas;
    bool podeCurar = true;
    public Button ButtonCurar;
    private SomManagement somManagement;
    // Start is called before the first frame update
    void Start()
    {
        Vidas = FindObjectOfType(typeof(Vidas)) as Vidas;
        somManagement = FindObjectOfType(typeof(SomManagement))as SomManagement;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CurarVida()
    {
       
        if (podeCurar == true)
        {

            somManagement.TocarSom(somManagement.aumentarVida);
            /*Vidas.contVida += 2;
            Vidas.SetVida();
            podeCurar = false;
            ButtonCurar.interactable = false;*/

            if (Vidas.contVida == Vidas.contVidaInicial - 1)
            {
                Vidas.contVida++;
                Vidas.SetVida();
                podeCurar = false;
            }

            if (Vidas.contVida <= (Vidas.contVidaInicial - 2))
            {
                print("Testando");
                Vidas.contVida += 2;
                Vidas.SetVida();
                podeCurar = false;
                ButtonCurar.interactable = false;
            }
            else
            {
                podeCurar = true; 
            }

        }
        
        
    }
}
