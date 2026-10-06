using UnityEngine;

public class MoverObjeto : MonoBehaviour
{
    public Vector3 desplazamiento;

    private Vector3 posicionOriginal;

    void Start()
    {
        posicionOriginal = transform.position;
    }

    public void Mover()
    {
        transform.position = posicionOriginal + desplazamiento;
    }
}