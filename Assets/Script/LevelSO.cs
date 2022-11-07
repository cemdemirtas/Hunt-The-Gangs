using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelSO", menuName = "LevelSO")]

public class LevelSO : ScriptableObject
{
 
        public int levelIndex;
        public List<GameObject> spawnList;
        public List<GameObject> EnemyList;
    
   
}
