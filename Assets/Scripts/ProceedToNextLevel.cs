using UnityEngine;
using UnityEngine.SceneManagement;

public class ProceedToNextLevel : MonoBehaviour
{
    public void proceedToNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
