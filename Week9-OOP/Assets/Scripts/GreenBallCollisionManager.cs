using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public GameObject yellowBallPrefab;
    public GameObject plane; 
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");
        if (OtherBall.GetComponent<BlueBallCollisionManager>() != null)
        {
            Debug.Log("Green Collided With Blue");

            Instantiate(yellowBallPrefab, plane.transform);
        }
    }

    
}


