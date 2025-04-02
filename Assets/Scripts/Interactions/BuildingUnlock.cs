using UnityEngine;

public class BuildingUnlock : MonoBehaviour
{
    public int unlockLevel = 1; // Level when this becomes usable
    public GameObject buildingContent; // Optional: visuals/UI to enable/disable

    void Start()
    {
        if (GameProgressManager.Instance != null)
        {
            bool unlocked = GameProgressManager.Instance.HasUnlocked(unlockLevel);

            if (buildingContent != null)
                buildingContent.SetActive(unlocked);

            // Disable the collider if it's not unlocked yet
            Collider col = GetComponent<Collider>();
            if (col != null)
                col.enabled = unlocked;
        }
    }
}
