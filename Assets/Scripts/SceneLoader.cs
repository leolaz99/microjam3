using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;

    public void GoToGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }


    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
