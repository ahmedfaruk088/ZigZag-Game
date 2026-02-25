using UnityEngine;
using UnityEngine.SceneManagement;

public class BallInput : MonoBehaviour
{
    public Vector3 Direction;
    public float speed = 1f;
    private bool isGameStarted = false;
    private bool changeQueued = false;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Direction = Vector3.left;
        // Rigidbody'nin hýzý bozmamasý için isKinematic yapýyoruz
    }

    void Update()
    {
        // 1. Týklamayý yakala ve sýraya al
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            // Eðer oyun baþlamadýysa baþlat ve skoru aç
            if (!isGameStarted)
            {
                isGameStarted = true;
                if (ScoreManager.instance != null) ScoreManager.instance.StartScoring();
            }

            // Týklamayý her halükarda sýraya koy
            changeQueued = true;
        }

        // 2. Sýradaki yön deðiþimini tek seferde yap
        if (changeQueued)
        {
            ChangeDirection();
            changeQueued = false;
        }

        if (isGameStarted)
        {
            // Hareket yöntemi
            transform.Translate(Direction * speed * Time.deltaTime);
        }

        // Top düþtüðünde sahneyi sýfýrla
        if (transform.position.y <= -3f)
        {
            RestartGame();
        }
    }

    void ChangeDirection()
    {
        if (Direction.x == -1)
        {
            Direction = Vector3.forward;
        }
        else
        {
            Direction = Vector3.left;
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}