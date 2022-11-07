using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SummonEnemy : MonoBehaviour
{
    [SerializeField] List<Transform> spawnList;
    [SerializeField] List<GameObject> levelList;
    [SerializeField] LevelSO _levelSO;
    int randomise;
    private void OnEnable() => StartCoroutine(nameof(spawnPrefabs));

    IEnumerator spawnPrefabs()
    {
        for (int i = 0; i < spawnList.Count; i++)
        {
            randomise = Random.Range(0, spawnList.Count);
            GameObject instantiatedLevelPrefab = Instantiate(levelList[_levelSO.levelIndex].gameObject, spawnList[randomise].position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
