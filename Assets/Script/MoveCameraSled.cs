using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraSled : MonoBehaviour
{
    [SerializeField] GameObject Target;
    [SerializeField] GameObject T;

    [SerializeField] float speed;
    


    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Trineo");
        T = GameObject.FindGameObjectWithTag("Target");

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(Target.transform);
        float sled_Move = Mathf.Abs(Vector3.Distance(this.transform.position, T.transform.position) * speed);
        this.transform.position = Vector3.MoveTowards(this.transform.position, T.transform.position, sled_Move * Time.deltaTime);   


    }
}
