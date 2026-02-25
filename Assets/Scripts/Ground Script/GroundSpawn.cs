using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    public GameObject lastGround;
    [SerializeField] private GameObject groundPrefab;
    private GameObject newGround;
    private int GroundDirection;
    void Start()
    {
        GenerateRandomGround();
    }

    private void GenerateRandomGround()
    {
        for (int i = 0; i < 100; i++)
        {
            CreateNewGround();
        }
    }
    private void CreateNewGround()
    {
        GroundDirection = Random.Range(0, 2);
        if (GroundDirection == 0)
        {
            newGround = Instantiate(groundPrefab, new Vector3(lastGround.transform.position.x - 1f, lastGround.transform.position.y, lastGround.transform.position.z), Quaternion.identity);
            lastGround = newGround;
        }
        else
        {
            newGround = Instantiate(groundPrefab, new Vector3(lastGround.transform.position.x, lastGround.transform.position.y, lastGround.transform.position.z + 1f), Quaternion.identity);
            lastGround = newGround;
        }
    }
}