using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Transicao : MonoBehaviour
{
    public Text acertos;
    public Text Beneficios; 
    // Start is called before the first frame update
    void Start()
    {
        acertos.text = ("Você acertou " + (Perguntas.pontos).ToString() + " de 6 perguntas");
        SetTextBeneficios();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTextBeneficios()
    {
        switch (Perguntas.pontos)
        {
            case 0:
                Beneficios.text = ("Vida começa com 2, nenhum botão especial liberado");
                break; 
            case 1:
                Beneficios.text = ("Vida no padrão, nenhum botão especial liberado");
                break;
            case 2:
                Beneficios.text = ("Mais 2 vidas, nenhum botão especial liberado");
                break;
            case 3:
                Beneficios.text = ("Mais 2 vidas, nenhum botão especial liberado");
                break;
            case 4:
                Beneficios.text = ("Mais 3 vidas, botão cura liberado");
                break;
            case 5:
                Beneficios.text = ("Mais 3 vidas, botão destói tudo e cura liberados");
                break;
            case 6:
                Beneficios.text = ("Comece a partida com o dobro de vida, botão destói tudo e cura liberados");
                break;
        }
    }
}
