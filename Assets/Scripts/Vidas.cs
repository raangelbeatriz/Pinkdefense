using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public Image vida0;
    public Image vida1;
    public Image vida2;
    public Image vida3;
    public Image vida4;
    public Image vida5;
    public Image vida6;
    public Image vida7;
    public Image vida8;
    public Image vida9;
    public Image vida10;
    public static int contVida = 5;
    public Button Cura;
    public Button MatarGeral;
    public Text Pontuacao;
    public int Teste;
    public static float PontoXtempo;
    public int pontosBatalha = 0;
    public GameObject PanelPause;
    public GameObject TelaPause;
    public GameObject TelaFinal;
    public static int contVidaInicial;
    public Text PontuacaoGeral;
    public SomManagement somManagement;
    // Start is called before the first frame update
    void Start()
    {
        somManagement = FindObjectOfType(typeof(SomManagement)) as SomManagement;
        ChangeScene.onBatalha = true;
        print("Começou");
        SetBeneficios();
        SetVida();
        contVidaInicial = contVida;
        print(contVidaInicial);
        Pontuacao.text = pontosBatalha.ToString();
        PanelPause.SetActive(false);
        TelaFinal.SetActive(false);
        TelaPause.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        somManagement.TocarSom(somManagement.peitoPerdeVida);
        Destroy(collision.gameObject);
        contVida--;
        SetVida();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger");
    }

    public void  SetVida()
    {
        switch (contVida)
        {
             case 0:
                 vida0.enabled = true;
                 vida1.enabled = false;
                 vida2.enabled = false;
                 vida3.enabled = false;
                 vida4.enabled = false;
                 vida5.enabled = false;
                 vida6.enabled = false;
                 vida7.enabled = false;
                 vida8.enabled = false;
                 vida9.enabled = false;
                 vida10.enabled = false;
                somManagement.TocarSom(somManagement.peitoMorre);
                 Derrota();
                 break;

             case 1:
                 vida0.enabled = false;
                 vida1.enabled = true;
                 vida2.enabled = false;
                 vida3.enabled = false;
                 vida4.enabled = false;
                 vida5.enabled = false;
                 vida6.enabled = false;
                 vida7.enabled = false;
                 vida8.enabled = false;
                 vida9.enabled = false;
                 vida10.enabled = false;
                 break;

             case 2:
                 vida0.enabled = false;
                 vida1.enabled = false;
                 vida2.enabled = true;
                 vida3.enabled = false;
                 vida4.enabled = false;
                 vida5.enabled = false;
                 vida6.enabled = false;
                 vida7.enabled = false;
                 vida8.enabled = false;
                 vida9.enabled = false;
                 vida10.enabled = false;
                 break;
             case 3:
                 vida0.enabled = false;
                 vida1.enabled = false;
                 vida2.enabled = false;
                 vida3.enabled = true;
                 vida4.enabled = false;
                 vida5.enabled = false;
                 vida6.enabled = false;
                 vida7.enabled = false;
                 vida8.enabled = false;
                 vida9.enabled = false;
                 vida10.enabled = false;
                 break;
             case 4:
                 vida0.enabled = false;
                 vida1.enabled = false;
                 vida2.enabled = false;
                 vida3.enabled = false;
                 vida4.enabled = true;
                 vida5.enabled = false;
                 vida6.enabled = false;
                 vida7.enabled = false;
                 vida8.enabled = false;
                 vida9.enabled = false;
                 vida10.enabled = false;
                 break;

             case 5:
                 vida0.enabled = false;
                 vida1.enabled = false;
                 vida2.enabled = false;
                 vida3.enabled = false;
                 vida4.enabled = false;
                 vida5.enabled = true;
                 vida6.enabled = false;
                 vida7.enabled = false;
                 vida8.enabled = false;
                 vida9.enabled = false;
                 vida10.enabled = false;
                 break;


             case 6:
                 vida0.enabled = false;
                 vida1.enabled = false;
                 vida2.enabled = false;
                 vida3.enabled = false;
                 vida4.enabled = false;
                 vida5.enabled = false;
                 vida6.enabled = true;
                 vida7.enabled = false;
                 vida8.enabled = false;
                 vida9.enabled = false;
                 vida10.enabled = false;
                 break;


             case 7:
                 vida0.enabled = false;
                 vida1.enabled = false;
                 vida2.enabled = false;
                 vida3.enabled = false;
                 vida4.enabled = false;
                 vida5.enabled = false;
                 vida6.enabled = false;
                 vida7.enabled = true;
                 vida8.enabled = false;
                 vida9.enabled = false;
                 vida10.enabled = false;
                 break;

             case 8:
                 vida0.enabled = false;
                 vida1.enabled = false;
                 vida2.enabled = false;
                 vida3.enabled = false;
                 vida4.enabled = false;
                 vida5.enabled = false;
                 vida6.enabled = false;
                 vida7.enabled = false;
                 vida8.enabled = true;
                 vida9.enabled = false;
                 vida10.enabled = false;
                 break;


             case 9:
                 vida0.enabled = false;
                 vida1.enabled = false;
                 vida2.enabled = false;
                 vida3.enabled = false;
                 vida4.enabled = false;
                 vida5.enabled = false;
                 vida6.enabled = false;
                 vida7.enabled = false;
                 vida8.enabled = false;
                 vida9.enabled = true;
                 vida10.enabled = false;
                 break;

             case 10:
                 vida0.enabled = false;
                 vida1.enabled = false;
                 vida2.enabled = false;
                 vida3.enabled = false;
                 vida4.enabled = false;
                 vida5.enabled = false;
                 vida6.enabled = false;
                 vida7.enabled = false;
                 vida8.enabled = false;
                 vida9.enabled = false;
                 vida10.enabled = true;
                 break;
        }
    } 


    public void SetBeneficios()
    {
        switch (Perguntas.pontos)
        {
            case 0:
                contVida = 2;
                Cura.interactable = false;
                MatarGeral.interactable = false;
                break; 
            case 1:
                Cura.interactable = false;
                MatarGeral.interactable = false;
                break;
            case 2:
                contVida += 2;
                Cura.interactable = false;
                MatarGeral.interactable = false;
                break;
            case 3:
                contVida += 2;
                Cura.interactable = false;
                MatarGeral.interactable = false;
                break;
            case 4:
                contVida += 3;
                Cura.interactable = true;
                MatarGeral.interactable = false;
                break;
            case 5:
                contVida += 3;
                Cura.interactable = true;
                MatarGeral.interactable = true; //Passar pra false
                break;
            case 6:
                contVida = contVida * 2;
                Cura.interactable = true;
                MatarGeral.interactable = true;
                break; 
        }
    }


    public void SetPontucao(){
        pontosBatalha += 10;
        Pontuacao.text = pontosBatalha.ToString();
        PontoXtempo = pontosBatalha/500;
    }

    public void Derrota()
    {
        if (contVida == 0)
        {
            Time.timeScale = 0;
            PanelPause.SetActive(true);
            TelaPause.SetActive(false);
            TelaFinal.SetActive(true);
            PontuacaoGeral.text = "Sua pontuação foi de " + pontosBatalha.ToString();
        }
    }
}
