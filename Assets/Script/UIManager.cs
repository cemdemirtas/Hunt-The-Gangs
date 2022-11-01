using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public static UnityAction UpgradePanelEvent;
    public UnityAction KillEvent;
    public UnityAction PlayerDieEvent;

    [SerializeField] GameObject _upgradePanel;
    [SerializeField] TowerSO _towerSO;


    //[SerializeField] LevelSO _levelSO;
    //[SerializeField] UpgradeSO _upgradeSO;
    private void Awake()
    {
        if (Instance == null) { Instance = this; }
    }

    private void OnEnable()
    {
        UpgradePanelEvent += UpgradePanelShow;
    }
    private void OnDisable()
    {
        UpgradePanelEvent -= UpgradePanelShow;

    }
    public void UpgradePanelShow()
    {
        _upgradePanel.gameObject.SetActive(true);
        _towerSO.killCount = 0;
        Time.timeScale = 0;
    }
    public void UpgradePanelHide()
    {
        _upgradePanel.gameObject.SetActive(false);
        Time.timeScale = 1;

    }
}
