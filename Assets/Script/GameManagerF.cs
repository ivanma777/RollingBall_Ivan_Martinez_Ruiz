using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerF : MonoBehaviour
{
    

    [SerializeField] TMP_Text RegalosRecogidos;
    [SerializeField] TMP_Text intentosRealizados;
    [SerializeField] TMP_Text timer;
    [SerializeField] TMP_Text nota;

    private string calificacion;

    private int Ncoleccionable;

    private int regalos ;

    private int intentos;

    private float tiempo;



    private bool regalosT;
    private bool intentosT;
    private bool tiempoT;
    public int Ncoleccionable1 { get => Ncoleccionable; set => Ncoleccionable = value; }
    

    // Start is called before the first frame update
    void Start()
    {
        LogicaPuntuacion();
        LogicaPf();

        RegalosRecogidos.SetText("Regalos totales recogidos: " + regalos  + " / " + Ncoleccionable1);

        intentosRealizados.SetText("N intentos: " + intentos );

        timer.SetText("Tiempo: " + tiempo.ToString("F2"));

        nota.SetText( calificacion );
        
        
    }

    // Update is called once per frame
    void Update()
    {
        




       
            








    }

    void LogicaPuntuacion()
    {
        if (intentos == 0)
        {
            intentosT = true;

        }
        else
        {
            intentosT = false;
        }
        if (regalos == 6)
        {
            regalosT = true;

        }
        else
        {
            regalosT = false;
        }
        if (tiempo < 90f)
        {
            tiempoT = true;

        }
        else
        {
            tiempoT = false;
        }

    }

    void LogicaPf()
    {
        if (regalosT && intentosT && tiempoT)
        {
            calificacion = "S";

        }
        else if (regalosT && tiempoT || regalosT && intentosT || intentosT && tiempoT)
        {

            calificacion = "A";

        }
        else if (regalosT || tiempoT || regalosT)
        {
            calificacion = "B";

        }
        else
        {
            calificacion = "C";
        }
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
        AlmacenDatos.instance.tiempo = tiempo;



    }

    void LoadData()
    {
        regalos = AlmacenDatos.instance.regalos;
        Ncoleccionable = AlmacenDatos.instance.Ncoleccionable;
        intentos = AlmacenDatos.instance.intentos;
        tiempo = AlmacenDatos.instance.tiempo;
    }

}
