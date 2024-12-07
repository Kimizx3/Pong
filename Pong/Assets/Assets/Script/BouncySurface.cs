using System;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;
    public SFXManager SfxManager;
    public GameObject playerPaddle;
    public GameObject computerPaddle;
    public GameObject topWall;
    public GameObject bottomWall;

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        Ball ball = collision2D.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector2 normal = collision2D.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);

            if (gameObject == playerPaddle || gameObject == computerPaddle)
            {
                SfxManager.PlaySFX(SfxManager.ping);
            }
            else if (gameObject == topWall || gameObject == bottomWall)
            {
                SfxManager.PlaySFX(SfxManager.wallPong);
            }
            
        }
    }
}
