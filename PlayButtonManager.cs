using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonManager : MonoBehaviour
{
    public GameObject modeSelectionPanel; // Reference to the Mode Selection Panel
    // Play Button function
    public void OpenModeSelectionPanel()
    {
        modeSelectionPanel.SetActive(true); // To active panel
    }

    // Cross Button function
    public void CloseModeSelectionPanel()
    {
        modeSelectionPanel.SetActive(false); // To active panel
    }
}
