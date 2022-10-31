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
    public Rigidbody Rb => _rb;


    private void OnEnable()
    {
        totalHp = 100;
        //totalHp = _enemySO.Health;
    }
    void Update()
    {
        var dir = new Vector3(Mathf.Cos(Time.time * _moveSpeed) * _size, Mathf.Sin(Time.time * _moveSpeed) * _size);
        _rb.velocity = dir;
    }
    public void Explode()
    {
        this.totalHp = this.totalHp - 50;
        _healthBarImage.fillAmount = totalHp/100;
        Debug.Log("Total HP" + totalHp);
        if (totalHp <= 0) gameObject.SetActive(false);
    }
}
