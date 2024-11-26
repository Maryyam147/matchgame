using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject settingsPanel; // Reference to the settings panel

    // Open the settings panel
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    // Close the settings panel
    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }
        public GameObject modeSelectionPanel; // Mode Selection Panel ka reference

        // Play Button ke liye function
        public void OpenModeSelectionPanel()
        {
            modeSelectionPanel.SetActive(true); // Mode Selection Panel ko active karega
        }

        // Cross Button ke liye function
        public void CloseModeSelectionPanel()
        {
            modeSelectionPanel.SetActive(false); // Mode Selection Panel ko hide karega
        }
    }
