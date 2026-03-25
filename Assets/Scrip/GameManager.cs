using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartGame()
    {
        Time.timeScale = 1f; // กลับเวลาเป็นปกติ
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}