using UnityEngine;

public class DestroyBalls : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Ball ball))
        {
            Destroy(ball.gameObject);
        }
    }
}
