using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class LoadingScence : MonoBehaviour
{
    public static LoadingScence instance;
    [SerializeField] private GameObject _loaderCanvas;
    [SerializeField] private Slider _progressBar;
    
    private float _target;
    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    public async void LoadingScenceFunc(int indexScene) {
        _target = 0;
        _progressBar.value = 0;

        var scence = SceneManager.LoadSceneAsync(indexScene);
        scence.allowSceneActivation = false;

        _loaderCanvas.SetActive(true);

        do {
            await Task.Delay(100);
            _target = scence.progress;        
        } while(scence.progress < 0.9f);

        await Task.Delay(1000);
        scence.allowSceneActivation = true;
        _loaderCanvas.SetActive(false);
    }

    private void Update() {
        _progressBar.value = Mathf.MoveTowards(_progressBar.value, _target, 3*Time.deltaTime);
    }
}
