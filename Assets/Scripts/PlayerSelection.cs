using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelection : MonoBehaviour
{
    public static PlayerSelection Instance { get; private set; }
    public Color PlayerColor { get; private set; }
    public string PlayerName { get; private set; }

    public int HighScore { get; private set; }

    public TMP_InputField playerNameInput;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Method to set the player color and start the game
    public void StartGameWithRedColor()
    {
        StartGameWithColor(Color.red);
    }

    public void StartGameWithBlueColor()
    {
        StartGameWithColor(Color.blue);
    }

    public void StartGameWithGreenColor()
    {
        StartGameWithColor(Color.green);
    }

    public void StartGameWithYellowColor()
    {
        StartGameWithColor(Color.yellow);
    }

    // General method to set the player color and start the game
    private void StartGameWithColor(Color color)
    {
        PlayerColor = color;
        PlayerName = playerNameInput.text;
        SceneManager.LoadScene("main");
    }
}