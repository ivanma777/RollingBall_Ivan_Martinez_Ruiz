using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerF : MonoBehaviour
{
    

    [SerializeField] TMP_Text RegalosRecogidos;
    [SerializeField] TMP_Text intentosRealizados;

     

    private int Ncoleccionable;

    private int regalos ;

    private int intentos;
    
    
    public int Ncoleccionable1 { get => Ncoleccionable; set => Ncoleccionable = value; }
    

    // Start is called before the first frame update
    void Start()
    {
        
        RegalosRecogidos.SetText("Regalos totales recogidos: " + regalos  + " / " + Ncoleccionable1);

        intentosRealizados.SetText("N intentos: " + intentos );
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnDestroy()
    {

        SaveData();
    }
    private void Awake()
    {
        LoadData();
    }


    void SaveData()
    {
        AlmacenDatos.instance.Ncoleccionable = Ncoleccionable;
        AlmacenDatos.instance.regalos = regalos;
        AlmacenDatos.instance.intentos = intentos;


    }

    void LoadData()
    {
        regalos = AlmacenDatos.instance.regalos;
        Ncoleccionable = AlmacenDatos.instance.Ncoleccionable;
        intentos = AlmacenDatos.instance.intentos;
    }

}
