using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeManager : MonoBehaviour
{
    [SerializeField] private int life = 1;
    [Tooltip("True is not Death")][SerializeField] private bool noDeathMode = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!noDeathMode && (collision.CompareTag("Enemy") || collision.CompareTag("Graund")))
        {
            life -= 1;
            if (life <= 0)
            {
                Time.timeScale = 0;
                UIManager.instance.OpenGameOverCanvas();
            }
        }
    }
}
