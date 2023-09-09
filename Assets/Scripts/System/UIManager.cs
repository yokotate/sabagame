using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField] private GameObject gameOverCanvas;

    private void Start()
    {
        instance = this;
    }

    public void OpenGameOverCanvas()
    {
        gameOverCanvas.SetActive(true);
    }
}
