using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using DG.Tweening;

public class LoadingScreen : MonoBehaviour
{
    [Header("Slider")]
    public Slider loadingSlider; // Attach your Slider UI element here

    [Header("Variable")]
    public string sceneToLoad;   // Name of the scene you want to load

    [Header("GameObject")]
    public GameObject logo;
    public GameObject text;

    void Start()
    {
        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneToLoad);
        operation.allowSceneActivation = false;

        // Initialize slider for animation
        loadingSlider.value = 0;

        while (!operation.isDone)
        {
            // Smooth transition of slider using DoTween
            float targetValue = Mathf.Clamp01(operation.progress / 0.9f);
            loadingSlider.DOValue(targetValue, 0.3f).SetEase(Ease.OutCubic);

            // Check if load is complete
            if (operation.progress >= 0.9f)
            {
                // Fill slider to 100% smoothly
                loadingSlider.DOValue(1f, 1f).SetEase(Ease.OutCubic);
                yield return new WaitForSeconds(3); // Simulate a delay
                operation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
