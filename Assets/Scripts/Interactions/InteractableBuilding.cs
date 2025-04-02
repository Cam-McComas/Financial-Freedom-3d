using UnityEngine;

public class InteractableBuilding : MonoBehaviour
{
    public string buildingName = "Bank";
    public GameObject promptUI; // 👈 Assign in Inspector

    private bool isPlayerNear = false;

    void Start()
    {
        if (promptUI != null)
            promptUI.SetActive(false); // Hide prompt initially
    }

    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Interacted with: " + buildingName);
            // TODO: Trigger UI panel or event here
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
            if (promptUI != null)
                promptUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
            if (promptUI != null)
                promptUI.SetActive(false);
        }
    }
}
