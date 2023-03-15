using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    public float velocidadRotacion = 20.0f;
    public Transform pivote; 


    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(pivote.transform.position, Vector3.up, velocidadRotacion*Time.deltaTime) ;
    }
}
