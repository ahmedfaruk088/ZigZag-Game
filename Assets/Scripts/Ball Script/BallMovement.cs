using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private Data data;
    [SerializeField] public float speed;
    // Update is called once per frame
    void Update()
    {
        SetBallMovement();
    }
    public void SetBallMovement()
    {
        transform.position += data.GetBallDirection() * speed * Time.deltaTime;
    }

}