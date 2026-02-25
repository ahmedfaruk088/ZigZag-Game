using UnityEngine;

public class GroundCollision : MonoBehaviour
{
    [SerializeField] private GroundDataTransmitter dataTransmitter;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            dataTransmitter.SetGroundRigidbodyValue();
        }
    }
}

