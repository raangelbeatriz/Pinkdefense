using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomManagement: MonoBehaviour
{
    public AudioSource sMusic; //Musica de fundo
    public AudioSource sFx; //Efeito

    [Header("Plano de Fundo")]
    public AudioClip MusicaInicial;
    public AudioClip Batalha;


    [Header("Fx")]
    public AudioClip fxClique;
    public AudioClip respostaCerta;
    public AudioClip respostaErrada;
    public AudioClip matarTumor;
    public AudioClip peitoMorre;
    public AudioClip peitoPerdeVida;
    public AudioClip matarGeral;
    public AudioClip aumentarVida;


    private float volumeMaximoMusica;
    private float volumeMaximoFx; 
    private AudioClip novaMusica;
    private string novaCena;
    private bool trocarCena;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        volumeMaximoMusica = 1;
        volumeMaximoFx = 1;
        TocarMusic(MusicaInicial, "Inicial", false);
    }

    // Update is called once per frame
    public void TocarSom(AudioClip som)
    {
        sFx.PlayOneShot(som); 
    }



    public void  TocarMusic (AudioClip clip, string nomeCena, bool mudarCena)
    {
        novaMusica = clip;
        novaCena = nomeCena;
        trocarCena = mudarCena;

        StartCoroutine("changeMusic");



    }

    IEnumerator changeMusic()
    {
        {
            for (float volume = volumeMaximoMusica; volume >= 0; volume -= 0.2F) //volume -= 0.1F
            {
                yield return new WaitForSeconds(0.1f); //volume -= 0.1F
                sMusic.volume = volume;
            }
        }
        sMusic.volume = 0;
        print("Volume Música Antiga =" + sMusic.volume);
        sMusic.clip = novaMusica;
        sMusic.Play();

        for (float volume = 0; volume < volumeMaximoMusica; volume += 0.2F)
        {
            yield return new WaitForSeconds(0.1f);
            sMusic.volume = volume;
        }
        sMusic.volume = volumeMaximoMusica;


    }



}
