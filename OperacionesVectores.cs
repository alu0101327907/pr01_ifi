using UnityEngine;

public class OperacionesVectores : MonoBehaviour
{
    // Vectores que podemos modificar desde el Inspector
    public Vector3 vector1;
    public Vector3 vector2;

    // Resultados
    public float magnitudVector1;
    public float magnitudVector2;
    public float angulo;
    public float distancia;
    public string vectorMasAlto;

    // Posición de la esfera
    public Vector3 posicionEsfera;

    void Start()
    {
        // Magnitud de cada vector
        magnitudVector1 = vector1.magnitude;
        magnitudVector2 = vector2.magnitude;

        // Ángulo entre los dos vectores
        angulo = Vector3.Angle(vector1, vector2);

        // Distancia entre los dos vectores
        distancia = Vector3.Distance(vector1, vector2);

        // Comprobar qué vector está a mayor altura
        if (vector1.y > vector2.y)
        {
            vectorMasAlto = "El vector 1 está a mayor altura.";
        }
        else if (vector2.y > vector1.y)
        {
            vectorMasAlto = "El vector 2 está a mayor altura.";
        }
        else
        {
            vectorMasAlto = "Los dos vectores están a la misma altura.";
        }

        // Obtener la posición de la esfera
        posicionEsfera = transform.position;

        // Mostrar resultados en la consola
        Debug.Log("Magnitud del vector 1: " + magnitudVector1);
        Debug.Log("Magnitud del vector 2: " + magnitudVector2);
        Debug.Log("Ángulo entre los vectores: " + angulo + " grados");
        Debug.Log("Distancia entre los vectores: " + distancia);
        Debug.Log(vectorMasAlto);
        Debug.Log("Posición de la esfera: " + posicionEsfera);
    }
}