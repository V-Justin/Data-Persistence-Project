using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float Speed = 2.0f;
    public float MaxMovement = 2.0f;
    public TextMeshProUGUI playerNameDisplay;

    private Renderer paddleRenderer;

    // Start is called before the first frame update
    void Start()
    {
        paddleRenderer = GetComponent<Renderer>();
        if (PlayerSelection.Instance != null)
        {
            SetColor(PlayerSelection.Instance.PlayerColor);
            if (playerNameDisplay != null)
            {
                playerNameDisplay.text = PlayerSelection.Instance.PlayerName;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Horizontal");

        Vector3 pos = transform.position;
        pos.x += input * Speed * Time.deltaTime;

        if (pos.x > MaxMovement)
            pos.x = MaxMovement;
        else if (pos.x < -MaxMovement)
            pos.x = -MaxMovement;

        transform.position = pos;
    }

    void SetColor(Color color)
    {
        if (paddleRenderer != null)
        {
            paddleRenderer.material.color = color;
        }
    }
}