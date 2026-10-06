using UnityEngine;

public class Disparo : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("disparo"))
        {
            Debug.Log("¡Disparo!");
        }
    }
}

