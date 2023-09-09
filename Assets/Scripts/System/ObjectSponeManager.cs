using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSponeManager : MonoBehaviour
{
    [Header("Spoen Point Setting")]
    [SerializeField] private GameObject sponePointObject;
    [SerializeField] private float sponePointYmin = 4.5f;
    [SerializeField] private float sponePointYmax = -4.5f;
    private Transform sponePointTran;
    private float sponePointX;

    [Header("Enemy Setting")]
    [SerializeField] private GameObject sponeEnemyObject;
    [SerializeField] private bool sponeEnemyFlag = true;
    [SerializeField] private float sponeTimeEnemy;
    [SerializeField] private float sponeCurrentTimeEnemy;

    private void Start()
    {
        sponePointTran = sponePointObject.transform;
        sponePointX = sponePointTran.position.x;
    }

    private void Update()
    {
        if (sponeEnemyFlag)
        {
            sponeCurrentTimeEnemy += Time.deltaTime;
            if(sponeCurrentTimeEnemy > sponeTimeEnemy)
            {
                sponeCurrentTimeEnemy = 0;
                SponeObject(sponeEnemyObject);

            }
        }
    }

    void SponeObject(GameObject obj) 
    {
        var sponePointY = Random.Range(sponePointYmin, sponePointYmax);
        Instantiate(obj, new Vector2(sponePointX, sponePointY), Quaternion.identity);
    }
}
