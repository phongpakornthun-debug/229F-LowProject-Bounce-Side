using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLose : MonoBehaviour
{
    [SerializeField] private GameObject loseUI;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (loseUI != null)
            loseUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeadZone"))
        {
            Lose();
        }
    }

    void Lose()
    {
        if (loseUI != null)
        {
            loseUI.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Lose UI ยังไม่ได้ใส่ใน Inspector!");
        }

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}