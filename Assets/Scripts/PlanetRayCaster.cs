using UnityEngine;
using TMPro;

public class PlanetRaycaster : MonoBehaviour
{
    public GameObject infoPanel;
    public TMP_Text infoText;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Debug.Log("Clicked: " + hit.transform.name);

                infoPanel.SetActive(true);

                PlanetInfo info = hit.transform.GetComponent<PlanetInfo>();

                if (info != null)
                {
                    infoText.text = info.planetName + "\n\n" + info.description;
                }
                else
                {
                    infoText.text = hit.transform.name;
                }
            }
        }
    }
}