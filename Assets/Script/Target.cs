using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;
using UnityEngine.UI;

public class Target : MonoBehaviour, IExplode
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _size = 10;
    [SerializeField] private float _moveSpeed = 10;
    private float totalHp;
    [SerializeField] private Image _healthBarImage;
    [SerializeField] private EnemySO _enemySO;
    [SerializeField] private TowerSO _towerSO;

    public Rigidbody Rb => _rb;


    private void OnEnable()
    {
        totalHp = _enemySO.Health;
        //totalHp = _enemySO.Health;
    }
    void Update()
    {
        var dir = new Vector3(Mathf.Cos(Time.time * _moveSpeed) * _size, Mathf.Sin(Time.time * _moveSpeed) * _size);
        _rb.velocity = dir;
    }
    public void Explode()
    {
        totalHp = totalHp - 50;
        _healthBarImage.fillAmount = totalHp / _enemySO.Health;
        if (totalHp <= 0) kil();
    }
    void kil()
    {
        _towerSO.killCount++;
        if (_towerSO.killCount >= 50) UIManager.UpgradePanelEvent?.Invoke();
        gameObject.SetActive(false);
    }
}
