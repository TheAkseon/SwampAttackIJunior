using TMPro.EditorUtilities;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
