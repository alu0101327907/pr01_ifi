using UnityEngine;

public class DistanciaCuboCilindro : MonoBehaviour
{
    public GameObject cubo;
    public GameObject cilindro;

    void Start()
    {
        // Buscar el cubo y el cilindro por sus etiquetas
        cubo = GameObject.FindWithTag("cubo");
        cilindro = GameObject.FindWithTag("cilindro");

        // Obtener sus posiciones
        Vector3 posicionCubo = cubo.transform.position;
        Vector3 posicionCilindro = cilindro.transform.position;

        // Calcular la distancia entre ambos
        float distancia = Vector3.Distance(posicionCubo, posicionCilindro);

        // Mostrar la distancia en la consola
        Debug.Log("La distancia entre el cubo y el cilindro es: " + distancia);
    }
}