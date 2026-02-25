using UnityEngine;
using TMPro; // TextMeshPro bileþenleri için

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText; // Inspector'dan Text (TMP) objesini buraya sürükle

    private float score = 0;
    private bool isGameActive = false;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        // Oyun baþýnda ekrandaki yazý
        if (scoreText != null)
            scoreText.text = "Score : 0";
    }

    void Update()
    {
        if (isGameActive)
        {
            // Zaman geçtikçe skoru artýrýr
            score += Time.deltaTime * 5;
            scoreText.text = "Score : " + Mathf.FloorToInt(score).ToString() ;
        }
    }

    public void StartScoring()
    {
        isGameActive = true;
    }
}