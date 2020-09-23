using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public string cenaDestino;
    public static bool onBatalha = false;
    private SomClique somClique;
    private SomManagement SomManagement; 
    // Start is called before the first frame update
    void Start()
    {
        onBatalha = false; 
        somClique = FindObjectOfType(typeof(SomClique)) as SomClique;
        SomManagement = FindObjectOfType(typeof(SomManagement)) as SomManagement;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Changescene()
    {
        SomManagement.TocarSom(SomManagement.fxClique);
        if (cenaDestino == "Batalha")
        {
            print("Batalha");
            SomManagement.TocarMusic(SomManagement.Batalha, "Batalha", true);
            SceneManager.LoadScene(cenaDestino);
        }
        
        
        //Arrumar
        else if (cenaDestino == "Inicial")
        {
            SomManagement.TocarMusic(SomManagement.MusicaInicial, "Inicial", true);
            Perguntas.pontos = 0;
            Vidas.contVida = 5; //Pq sempre começa do 5 e apartir dai eu mexo
            Time.timeScale = 1; //Pq na Derrota eu seto como zero para pausar td
            onBatalha = false;
            SceneManager.LoadScene(cenaDestino);
            //Vidas.contVidaInicial = 0;
        }
        else
        {
            SceneManager.LoadScene(cenaDestino);
        }

    }


}
