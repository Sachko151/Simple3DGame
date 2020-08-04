
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndofGame : MonoBehaviour
{
    public void ButtonIsPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
