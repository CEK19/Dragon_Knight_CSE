using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    [SerializeField] private GameObject menuCanva;
    private void Update() {
        if (menuCanva != null) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                if (menuCanva.activeInHierarchy == false) {
                    Time.timeScale = 0;
                    menuCanva.SetActive(true);
                }

                else if (menuCanva.activeInHierarchy == true) {
                    Time.timeScale = 1;
                    menuCanva.SetActive(false);
                }   
            }            
        }
    }
    public void PlayGame() {
        LoadingScence.instance.LoadingScenceFunc(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Continue() {
        menuCanva.SetActive(false);
        Time.timeScale = 1;
    }

    public void PlayAgain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Exit() {
        Application.Quit();
    }
}