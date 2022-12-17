using UnityEngine;
using UnityEngine.UI;

public class ExitButtonHandler : MonoBehaviour
{
    [SerializeField] private Button _exitButton;

    private void Awake()
    {
        _exitButton.onClick.AddListener(ExitButtonOnclicked);
    }

    private void ExitButtonOnclicked()
    {
        Application.Quit();
    }
}