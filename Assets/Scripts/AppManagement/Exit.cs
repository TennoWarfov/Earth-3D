using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    [SerializeField] private Button _exitButton;

    private void Awake()
    {
        _exitButton.onClick.AddListener(AppExit);
    }

    private void OnDestroy()
    {
        _exitButton.onClick.RemoveListener(AppExit);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            AppExit();
        }
    }

    private void AppExit()
    {
        Application.Quit();
    }
}
