using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Vector3 newPosition;
    [SerializeField][Range(0, 3)] private float lerpvalue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - ballTransform.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetCameraFollow();

    }
    void SetCameraFollow()
    {
        newPosition = Vector3.Lerp(transform.position, ballTransform.position + offset, lerpvalue * Time.deltaTime);
        transform.position = newPosition;
    }
}
