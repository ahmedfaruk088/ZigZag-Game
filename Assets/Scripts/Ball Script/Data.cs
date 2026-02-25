using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Data : MonoBehaviour
{
    [SerializeField] private BallInput input;

    public Vector3 GetBallDirection()
    {
        return input.Direction;
    }
}
