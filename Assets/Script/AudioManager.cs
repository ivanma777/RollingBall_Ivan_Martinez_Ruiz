using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSourceSfx;
    [SerializeField] AudioSource Carrera;

     [SerializeField] PlayerInOut Entrada;

    [SerializeField] Salida Salida;

    private bool ventisca;

    public bool Ventisca { get => ventisca; set => ventisca = value; }

    // Start is called before the first frame update
    void Start()
    {
        Ventisca = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Ventisca)
        {
            
            audioSourceSfx.Play();
            Carrera.Stop();
        }
        else
        {
            Carrera.Play();
            audioSourceSfx.Stop();

        }



    }
    public void ReproducirSonido(AudioClip clip)
    {

        audioSourceSfx.PlayOneShot(clip);
    }


}
