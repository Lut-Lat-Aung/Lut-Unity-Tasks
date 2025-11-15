using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 20f;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
    }
}
