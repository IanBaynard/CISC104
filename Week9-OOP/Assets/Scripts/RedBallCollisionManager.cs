using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public GameObject blueBallPrefab;
    public GameObject yellowBallPrefab;
    public GameObject plane;

    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");
        if (OtherBall.GetComponent<GreenBallCollisionManager>() != null)
        {
            Debug.Log("Red Collided With Green");
            //Since Red Collided with Green it will Destory Green 
            Destroy(OtherBall);

        }
        if (OtherBall.GetComponent<YellowBallCollisionManager>() != null)
        {
            Debug.Log("Red Collided With Yellow");
            //Since Red Collided with Yellow it will change the color to black
            OtherBall.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        }

    }
}

