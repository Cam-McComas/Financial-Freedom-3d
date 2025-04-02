using UnityEngine;

public class UIPanelManager : MonoBehaviour
{
    public GameObject panelToClose;

    public void ClosePanel()
    {
        panelToClose.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f; // Resume game
    }
}
