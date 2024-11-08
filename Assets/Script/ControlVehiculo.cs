using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVehiculo : MonoBehaviour
{

  



    [SerializeField] float velocidadMaxima = 10f; // Velocidad m�xima que puede alcanzar el objeto
    [SerializeField] float aceleracion = 2f; // Aceleraci�n del objeto
    [SerializeField] float desaceleracion = 3f; // Desaceleraci�n cuando se deja de mover
    [SerializeField] private float smoothTime;
    [SerializeField] private float smoothTimeR;

    [SerializeField] private float anguloDerrape;
   

    [SerializeField] private float frenado ;

    [SerializeField] private float derrape;
    


    private float rotacionYActual = 0f;

    private Vector3 velocidadActual = Vector3.zero; // Velocidad actual del objeto

    public float SmoothTime { get => smoothTime; set => smoothTime = value; }
    public float RotacionYActual { get => rotacionYActual; set => rotacionYActual = value; }
    public float Aceleracion { get => aceleracion; set => aceleracion = value; }

    private Rigidbody rb;

    [Header("Musica")]
    [SerializeField] private AudioClip deslizar;
    [SerializeField] private AudioClip choque;
    private AudioManager audioManager;
    //private Quaternion rotacionInicial;

    private void Start()
    {
        /*rotacionInicial = transform.rotation*/;
        rb = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        // Obtenemos el input de movimiento (WASD o flechas)
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = 1;


        
        // Creamos un vector de direcci�n en base al input
        Vector3 direccionMovimiento = new Vector3(inputHorizontal, 0, inputVertical).normalized;


        // Si hay input, aceleramos
        if (direccionMovimiento.magnitude > 0)
        {
            //audioManager.ReproducirSonido(deslizar);
            // Incrementamos la velocidad en la direcci�n deseada
            velocidadActual += direccionMovimiento * Aceleracion * Time.fixedDeltaTime ;

            // Limitamos la velocidad a la velocidad m�xima
            if (velocidadActual.magnitude > velocidadMaxima)
            {
                velocidadActual = velocidadActual.normalized * velocidadMaxima;
            }
        }
        else
        {
            velocidadActual = Vector3.Lerp(velocidadActual, Vector3.zero, desaceleracion * Time.fixedDeltaTime);
        }

        //if (Input.GetKey(KeyCode.W))
        //{
        //    audioManager.ReproducirSonido(deslizar);

        //}
        // Si el jugador est� girando, aplicamos frenado y derrape
        if (inputHorizontal != 0)
        {
            velocidadActual *= frenado;
            //velocidadActual = Vector3.Lerp(velocidadActual, new Vector3(velocidadActual.x * derrape, velocidadActual.y, velocidadActual.z), Time.fixedDeltaTime);
            //Mathf.Clamp(rotacionYActual, 45, -45);
        }

        // Limitar el �ngulo de rotaci�n a [-45, 45]

        //rotacionYActual = Mathf.Clamp(rotacionYActual + inputHorizontal * smoothTimeR * Time.deltaTime, -anguloDerrape, anguloDerrape);
        // Movemos el objeto usando la velocidad actual
        velocidadActual = AdjustVelocityToSlope( velocidadActual );

        //transform.Translate(velocidadActual * Time.deltaTime);
        rb.MovePosition(rb.position + velocidadActual * Time.fixedDeltaTime);


        float inputRotacion = Input.GetAxis("Horizontal"); // Usa el mismo input para rotaci�n
        
            rotacionYActual += inputRotacion * SmoothTime ;


        // Aplicamos la rotaci�n limitada
        transform.rotation = Quaternion.Euler(0, rotacionYActual, 0) ;
        

        // Si no hay input, aplicamos desaceleraci�n




    }

    private Vector3 AdjustVelocityToSlope(Vector3 velocity)

    { 
        var ray = new Ray(transform.position, Vector3.down);
        
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 0.2f ))
        {
            var slopeRotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
            var adjustVelocity = slopeRotation * velocity;

            if (adjustVelocity.y < 0)
            {
                return adjustVelocity;

            }

        }
            return velocity;
    
    }
    //private CharacterController controller;

    //private float velocidadRotacion;

    //[SerializeField] private float velocidadMovimiento;
    //[SerializeField] private float velocidadMax;
    //[SerializeField] private float velocidadMin;


    ////Rigidbody rb;
    ////private Animator anim;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    controller = GetComponent<CharacterController>();
    //    //anim = GetComponent<Animator>();


    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    float h = Input.GetAxisRaw("Horizontal");
    //    float v = Input.GetAxisRaw("Vertical");



    //    transform.Translate(new Vector3(h, 0, v).normalized * velocidadMovimiento * Time.deltaTime);


    //    //transform.eulerAngles = new Vector3(h, 0, v) * Time.deltaTime;
    //    //Vector2 input = new Vector2(h, v);
    //    //if (input.magnitude > 0)
    //    //{
    //    //    //anim.SetBool("Walking", true);
    //    //    float angulo = Mathf.Atan2(input.x, input.y) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;



    //    //    float anguloSuave = Mathf.SmoothDampAngle(transform.eulerAngles.y, angulo, ref velocidadRotacion, smoothTime);

    //    //    transform.eulerAngles = new Vector3(0, anguloSuave, 0);

    //    //    Vector3 movimiento = Quaternion.Euler(0, angulo, 0) * Vector3.forward;

    //    //    //controller.Move(movimiento * velocidadMovimiento * Time.deltaTime);
    //    //}
    //    //else
    //    //{
    //    //    //anim.SetBool("Walking", false);
    //    //}

    //}
        
}
