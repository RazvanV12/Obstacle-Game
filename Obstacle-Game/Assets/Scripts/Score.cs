using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerPosition;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = playerPosition.position.z.ToString("0");
    }
}
