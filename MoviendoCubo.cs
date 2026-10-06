using UnityEngine;

public class MoviendoCubo : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    public float speed = 2f;

    void Update()
    {
        transform.Translate(
            moveDirection.x * speed * Time.deltaTime,
            moveDirection.y * speed * Time.deltaTime,
            moveDirection.z * speed * Time.deltaTime,
            Space.World
        );
    }
}
