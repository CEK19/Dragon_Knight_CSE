using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UpdateLevelUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI levelText;
    // Start is called before the first frame update
    void Start()
    {
        if (levelText != null) {
            levelText.SetText("LEVEL: " + SceneManager.GetActiveScene().buildIndex);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
