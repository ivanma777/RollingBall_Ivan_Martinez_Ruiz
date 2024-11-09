using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerF : MonoBehaviour
{
    [SerializeField] TMP_Text RegalosRecogidos;

    [SerializeField] Trineo trineo;

    private int Ncoleccionable;

   

    
    public int Ncoleccionable1 { get => Ncoleccionable; set => Ncoleccionable = value; }
    

    // Start is called before the first frame update
    void Start()
    {
        RegalosRecogidos.SetText("Regalos totales recogidos: " + trineo.Regalos + " / " + Ncoleccionable1);

        RegalosRecogidos.SetText("Nº intentos: " + trineo.Intentos );
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
