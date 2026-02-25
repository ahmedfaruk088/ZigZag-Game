using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    [SerializeField] private GroundFall groundFall;

    public void SetGroundRigidbodyValue()
    {
        StartCoroutine(groundFall.SetRigidbodyValue());

    }
}
