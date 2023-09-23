using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private GameObject scoreText;
    [SerializeField] private TextMeshProUGUI textComponent;
    [SerializeField] private float levelRate = 0.1f;
    float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // TODO: スコアの計算方法について考える
        var getScore = Time.deltaTime;
        score += getScore * (1 + levelRate * LevelManager.instance.GetLevel());
        textComponent.text = $"{score:0.00} m";
    }
}
