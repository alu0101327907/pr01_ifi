using UnityEngine;

public class VelocidadCubo : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float vertical = Input.GetAxis("Vertical");
            float resultado = velocidad * vertical;

            Debug.Log("Flecha arriba: " + resultado);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            float vertical = Input.GetAxis("Vertical");
            float resultado = velocidad * vertical;

            Debug.Log("Flecha abajo: " + resultado);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float horizontal = Input.GetAxis("Horizontal");
            float resultado = velocidad * horizontal;

            Debug.Log("Flecha izquierda: " + resultado);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            float horizontal = Input.GetAxis("Horizontal");
            float resultado = velocidad * horizontal;

            Debug.Log("Flecha derecha: " + resultado);
        }
    }
}

