using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnergyManager : MonoBehaviour
{
    private float maxEnergy = 100;
    private float minEnergy = 100;
    private float currentEnergy = 0;
    public float bonusGetEnergy = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentEnergy = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Esa"))
        {

        }
    }
}
