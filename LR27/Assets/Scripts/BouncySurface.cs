using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrenghth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        
        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrenghth);
        }
    }
}
