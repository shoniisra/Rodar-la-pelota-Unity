using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class jugadorController : MonoBehaviour
{
    Rigidbody rb;
    public Text puntuacion;
    public Text win;
    public int contador;
    public float velocidad;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        ActualizarMarcador();
        win.gameObject.SetActive(false);
    }
    public void FixedUpdate()
    {
        float movimientoHorizontal= Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal,0, movimientoVertical);
        rb.AddForce(movimiento*velocidad);

       
    }

    private void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        contador++;
        Debug.Log(contador);
        ActualizarMarcador();

        if (contador >= 2)
        {
            win.gameObject.SetActive(true);
        }
    }

    private void ActualizarMarcador()
    {
        puntuacion.text = "Puntuacion: " + contador;
    }
}
