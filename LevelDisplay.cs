using UnityEngine;
using TMPro; // Import the TextMeshPro namespace

public class LevelDisplay : MonoBehaviour
{
    public TextMeshProUGUI levelText; // Drag your TextMeshProUGUI component here

    void Start()
    {
        // Get the level number from PlayerPrefs
        int currentLevel = PlayerPrefs.GetInt("CurrentLevel", 1); // Default to 1 if not set
        levelText.text = "Level " + currentLevel; // Display the level
    }
}
