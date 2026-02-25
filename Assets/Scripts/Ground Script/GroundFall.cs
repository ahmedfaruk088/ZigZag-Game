using System.Collections;
using UnityEngine;

public class GroundFall : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public IEnumerator SetRigidbodyValue()
    {
        yield return new WaitForSeconds(1.2f);
        rb.useGravity = true;
        rb.isKinematic = false;
    }
}