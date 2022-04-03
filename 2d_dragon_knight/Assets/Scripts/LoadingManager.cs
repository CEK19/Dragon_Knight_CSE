using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    public void PlayGame() {
        LoadingScence.instance.LoadingScenceFunc(SceneManager.GetActiveScene().buildIndex + 1);
    }
}