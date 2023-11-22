using System.Collections;
using System.Collections.Generic;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class rbMovement : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 10f;
    public Transform groundCheck;
    public LayerMask groundMask;

    private Rigidbody rb;
    private bool enSuelo;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        enSuelo = Physics.CheckSphere(groundCheck.position, 0.1f, groundMask);

        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical) * velocidad;

        rb.AddForce(movimiento * velocidad);

        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }
}
