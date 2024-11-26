using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoinBarScript : MonoBehaviour
{
    public  TextMeshProUGUI coinsText; // Reference to the coin count text
    public Button plusButton; // Reference to the plus button
    private int coins;

    void Start()
    {
        LoadCoins(); // Load saved coin count at the start
        UpdateCoinsText();

        // Add a listener for the plus button click
        plusButton.onClick.AddListener(AddCoins);
    }

    private void AddCoins()
    {
        coins += 50; // Increase coins by 50
        UpdateCoinsText();
        SaveCoins(); // Save the new coin count
    }

    private void UpdateCoinsText()
    {
        coinsText.text = coins.ToString(); // Display updated coin count
    }

    private void SaveCoins()
    {
        PlayerPrefs.SetInt("CoinCount", coins); // Save coin count in PlayerPrefs
    }

    private void LoadCoins()
    {
        coins = PlayerPrefs.GetInt("CoinCount", 100); // Load coin count; default is 100
    }
}
