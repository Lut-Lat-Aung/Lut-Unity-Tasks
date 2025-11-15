using UnityEngine;

public class MovingPlatform : MonoBehaviour, IMovable
{
    [SerializeField] private Vector3 moveDirection = new Vector3(1, 0, 0);
    [SerializeField] private float moveSpeed = 2f;

    private void Update()
    {
        Move(moveDirection);
    }

    public void Move(Vector3 direction)
    {
        transform.position += direction.normalized * moveSpeed * Time.deltaTime;
    }
}
