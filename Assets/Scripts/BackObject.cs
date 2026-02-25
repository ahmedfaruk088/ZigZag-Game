using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void GoToMainMenu()
    {
        // Ana menü sahnenin adý "MainMenu" ise onu açar
        // Eðer tek sahnense ve sadece oyunu sýfýrlasýn istiyorsan 0 yazabilirsin
        SceneManager.LoadScene("Start Scene");
    }
}