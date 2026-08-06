using UnityEngine;

public class CloseInfo : MonoBehaviour
{
    public GameObject infoPanel;

    public void ClosePanel()
    {
        infoPanel.SetActive(false);
    }
}