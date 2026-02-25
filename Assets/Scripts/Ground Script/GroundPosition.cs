using UnityEngine;

public class GroundPosition : MonoBehaviour
{
    private Rigidbody rb;
    private GroundSpawn groundSpawn;
    [SerializeField] private float endYValue;
    private int groundDirection;

    void Start()
    {
        groundSpawn = FindAnyObjectByType<GroundSpawn>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Position();

    }
    private void Position()
    {
        if (transform.position.y <= endYValue)
        {
            Rigidbody();
            groundDirection = Random.Range(0, 2);

            if (groundDirection == 0)
            {
                transform.position = new Vector3(groundSpawn.lastGround.transform.position.x - 1f, groundSpawn.lastGround.transform.position.y, groundSpawn.lastGround.transform.position.z);

            }
            else
            {
                transform.position = new Vector3(groundSpawn.lastGround.transform.position.x, groundSpawn.lastGround.transform.position.y, groundSpawn.lastGround.transform.position.z + 1f);


            }
            groundSpawn.lastGround = gameObject;
        }
    }
    private void Rigidbody()
    {
        rb.useGravity = false;
        rb.isKinematic = true;
    }
}