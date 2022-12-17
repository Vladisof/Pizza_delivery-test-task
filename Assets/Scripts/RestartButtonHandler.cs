using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButtonHandler : MonoBehaviour
{
    [SerializeField] private Button _restartButton;

    private void Awake()
    {
        _restartButton.onClick.AddListener(RestartButtonOnclicked);
    }

    private void RestartButtonOnclicked()
    {
        SceneManager.LoadScene("SampleScene");
    }
}