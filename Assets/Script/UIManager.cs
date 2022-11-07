using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

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
        _upgradePanel.transform.DOScale(0,0.5f).OnComplete(()=>_upgradePanel.transform.DOScale(1, 0.5f));
        _upgradePanel.gameObject.SetActive(true);
        _towerSO.killCount = 0;
        Invoke(nameof(PauseGame), 1.5f);

    }
    public void UpgradePanelHide()
    {
        _upgradePanel.transform.DOScale(1, 0.5f).OnComplete(() => _upgradePanel.transform.DOScale(0, 0.5f));
        Continue();
        //_upgradePanel.gameObject.SetActive(false);

    }
    void PauseGame() => Time.timeScale = 0;
    void Continue() => Time.timeScale = 1;


}
