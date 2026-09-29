using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    // Se puede modificar desde el Inspector
    public int framesEspera = 120;

    private Vector3 valoresColor;
    private int contadorFrames;

    void Start()
    {
        // Inicializamos las 3 componentes del color
        valoresColor = new Vector3(
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f)
        );

        CambiarColorObjeto();
    }

    void Update()
    {
        contadorFrames++;

        if (contadorFrames >= framesEspera)
        {
            contadorFrames = 0;

            // Elegimos aleatoriamente una posición: 0, 1 o 2
            int posicion = Random.Range(0, 3);

            // Cambiamos esa posición por un nuevo valor aleatorio
            valoresColor[posicion] = Random.Range(0.0f, 1.0f);

            CambiarColorObjeto();
        }
    }

    void CambiarColorObjeto()
    {
        Color color = new Color(
            valoresColor.x,
            valoresColor.y,
            valoresColor.z
        );

        GetComponent<Renderer>().material.color = color;
    }
}