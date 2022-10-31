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
    [SerializeField] string _bulletType;

    [SerializeField] List<Transform> _missileList;

    private void Awake()
    {
        if (Instance == null) { Instance = this; }

        _shootingManager = GetComponent<ShootingManager>();

    }
    public void Fire(ShootingManager shootingManager)
    {
        //_bulletType = ((UpgradeSO.bulletTypeEnum)_upgradeSO.BulletCount).ToString();
        //Bullet_Forward_Force = _upgradeSO.BulletForwardSpeed;
        GameObject Temporary_Bullet_Handler = PoolingManager.instance.SpawnFromPool("Arrow", BulletEmitter.transform.position, Quaternion.Euler(0,180,0));
        Temporary_Bullet_Handler.SetActive(true);
    }

}
