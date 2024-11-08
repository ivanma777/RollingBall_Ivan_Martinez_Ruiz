using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSourceSfx;
    

     

    //private bool ventisca;

    //public bool Ventisca { get => ventisca; set => ventisca = value; }

    // Start is called before the first frame update
    void Start()
    {
        //Ventisca = true;
    }

    // Update is called once per frame
    void Update()
    {

        //if (Ventisca)
        //{
            
        //    audioSourceSfx.Play();
        //    Carrera.Stop();
        //}
        //else
        //{
        //    Carrera.Play();
        //    audioSourceSfx.Stop();

        //}
        //if (coleccionables)
        //{

        //    ReproducirColeccionable();
        //}


    }
    public void ReproducirColeccionable(AudioClip clip)
    {

        audioSourceSfx.PlayOneShot(clip);
    }

    


}
