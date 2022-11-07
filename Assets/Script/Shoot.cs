using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shoot : MonoBehaviour
{
    public static Shoot Instance;


    //[SerializeField] Transform Bullet_Emitter;
    //[SerializeField] GameObject Bullet;
    [SerializeField] GameObject BulletEmitter;
    [SerializeField] private float Bullet_Forward_Force;
    //[SerializeField] public Transform enemy;
    ShootingManager _shootingManager;
    //ClosestEnemy _closestEnemy;
    [SerializeField] public string _bulletType;
    [SerializeField] BulletSO _bulletSO;
    public static UnityAction ArrowCountEvent;


    private void OnEnable()
    {
        //_bulletType = UpgradeMechanic.bulletType;
        ArrowCountEvent += ArrowCount;
    }
    private void OnDisable()
    {
        ArrowCountEvent -= ArrowCount;
    }
    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        _bulletType = ((UpgradeMechanic.bulletEnum)(_bulletSO.ArrowType)).ToString();
        _shootingManager = GetComponent<ShootingManager>();

    }
    public void Fire(ShootingManager shootingManager)
    {
        GameObject Temporary_Bullet_Handler = PoolingManager.instance.SpawnFromPool(_bulletType, BulletEmitter.transform.position, Quaternion.Euler(0, 180, 0));
        Temporary_Bullet_Handler.SetActive(true);
    }
    public void ArrowCount()
    {
        _bulletType = ((UpgradeMechanic.bulletEnum)(_bulletSO.ArrowType)).ToString();
        Debug.Log("" + Shoot.Instance._bulletType);
    }

}
