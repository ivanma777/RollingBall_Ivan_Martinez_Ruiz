using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraSled : MonoBehaviour
{
    //[SerializeField] GameObject Target;
    //[SerializeField] CinemachineVirtualCamera T;

    //[SerializeField] float speed;
   

    // Start is called before the first frame update
    void Start()
    {
        //Target = GameObject.FindGameObjectWithTag("Trineo");
        //T = GetComponent<CinemachineVirtualCamera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.LookAt(Target.transform);
        //float sled_Move = Mathf.Abs(Vector3.Distance(this.transform.position, T.transform.position) * speed);
        //this.transform.position = Vector3.MoveTowards(this.transform.position, T.transform.position, sled_Move * Time.deltaTime);   
        float inputRotacion = Input.GetAxis("Horizontal"); // Usa el mismo input para rotación
        RotacionYActual += inputRotacion * smoothTime * Time.deltaTime;

        // Limitamos el ángulo de rotación a 45 grados
        RotacionYActual = Mathf.Clamp(RotacionYActual, -45f, 45f);

        // Aplicamos la rotación limitada
        transform.rotation = Quaternion.Euler(0, otacionYActual, 0);

    }

   
}
