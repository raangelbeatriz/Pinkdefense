using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class PauseButton : MonoBehaviour
{
    bool isPause = false;
    public GameObject pauseTela;
    public GameObject panelPause;
    public GameObject telaFinal;
    private SomManagement SomManagement;
    // Start is called before the first frame update
    public void Awake()
    {
        SomManagement = FindObjectOfType(typeof(SomManagement)) as SomManagement; 
    }

    public void Pausando() //Fazer o panel Bonitinho;
    {
        SomManagement.TocarSom(SomManagement.fxClique);
        if (isPause == false)
        {
            Time.timeScale = 0;
            panelPause.SetActive(true);
            telaFinal.SetActive(false);
            pauseTela.SetActive(true);
            isPause = true;
        }


        else if (isPause == true)
        {
            Time.timeScale = 1;
            panelPause.SetActive(false);
            telaFinal.SetActive(false);
            pauseTela.SetActive(false);
           
            isPause = false;
        }
    }
}
