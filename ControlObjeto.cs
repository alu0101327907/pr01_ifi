using UnityEngine;

public class ControlMovimiento : MonoBehaviour
{
    public MoverObjeto objeto1;
    public MoverObjeto objeto2;
    public MoverObjeto objeto3;

    void Update()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            objeto1.Mover();
            objeto2.Mover();
            objeto3.Mover();
        }
    }
}