using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // This function will be triggered when the button is clicked
    public void LoadMode1Scene()
    {
        SceneManager.LoadScene("Mode1Level1"); // Replace "Mode1Scene" with the exact name of your scene
    }
}
