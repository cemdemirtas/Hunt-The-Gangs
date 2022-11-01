using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TowerBuild : MonoBehaviour
{
    public static UnityAction TowerAddEvent;
    [SerializeField] private List<Transform> CrossbowList;
    [SerializeField] private TowerSO _towerSo;

    private void OnEnable()
    {
        for (int i = 0; i < _towerSo.towerCount; i++)
        {
            CrossbowList[i].gameObject.SetActive(true);
        }
        TowerAddEvent += AddCrossbow;
    }
    private void OnDisable()
    {
        TowerAddEvent -= AddCrossbow;

    }
    private void AddCrossbow()
    {
        for (int i = 0; i < _towerSo.towerCount; i++)
        {
            CrossbowList[i].gameObject.SetActive(true);
        }
    }
}
