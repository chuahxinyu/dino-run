using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame() {
        SceneManager.LoadScene("RestartButton");
    }

    
}