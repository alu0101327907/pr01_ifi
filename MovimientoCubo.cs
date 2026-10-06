using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    public float speed = 2f;
    public float rotationSpeed = 100f;

    void Update()
    {
        // Obtener el eje horizontal
        float horizontal = Input.GetAxis("Horizontal");

        // Girar el cubo
        transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);

        // Obtener la dirección hacia adelante del cubo
        Vector3 direccion = transform.forward;

        // Avanzar hacia adelante
        transform.Translate(
            direccion * speed * Time.deltaTime,
            Space.World
        );

        // Mostrar la dirección hacia adelante en la escena
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);
    }
}