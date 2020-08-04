using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTheGameScript : MonoBehaviour
{
    public void startTheGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
