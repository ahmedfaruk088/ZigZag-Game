using UnityEngine;
using UnityEngine.SceneManagement; // Sahneler arasý geçiþ için gerekli

public class StartManager : MonoBehaviour
{
    void Awake()
    {
        // Mobil performans için FPS'i 60'a sabitler
        Application.targetFrameRate = 60;
    }

    // Bu fonksiyonu butona baðlayacaksýn
    public void StartGame()
    {
        // "SampleScene" senin oyun sahnenin adý olmalý
        SceneManager.LoadScene("SampleScene");
    }
}