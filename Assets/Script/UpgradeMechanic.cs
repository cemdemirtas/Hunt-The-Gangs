using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMechanic : MonoBehaviour
{
    [SerializeField] TowerSO _towerSO;
    [SerializeField] BulletSO _bulletSO;
    public static string bulletType;

    public enum bulletEnum { Arrow1x = 1, Arrow2x = 2, Arrow3x = 3, Arrow4x = 4, Arrow5x = 5 };
    public void CrossbowIncrease()
    {
        _towerSO.towerCount++;
        if (_towerSO.towerCount > 4) _towerSO.towerCount = 4;
        UIManager.Instance.UpgradePanelHide();
        TowerBuild.TowerAddEvent?.Invoke();
    }

    public void ArrowCountIncrease()
    {
        _bulletSO.ArrowType++;
        if (_bulletSO.ArrowType > 3) _bulletSO.ArrowType = 3;
        Shoot.ArrowCountEvent?.Invoke();
        UIManager.Instance.UpgradePanelHide();
    }
}
