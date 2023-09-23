using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    [SerializeField] private float levelUpSpeed = 10.0f;

    private float currentLevelUpDeltaTime = 0;
    private int level = 0;

    void Awake(){
        instance = this;
    }

    void Start(){
        level = 0;
    }

    void Update(){
        currentLevelUpDeltaTime += Time.deltaTime;
        if(currentLevelUpDeltaTime >= levelUpSpeed){
            Debug.Log($"level : {level}");
            currentLevelUpDeltaTime = 0;
            level++;
        }
    }

    public int GetLevel(){
        return level;
    }
}
