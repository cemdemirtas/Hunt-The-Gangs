using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class ShootingManager : MonoBehaviour
{
    UnityAction shootEvent;

    //ClosestEnemy closestEnemy = new ClosestEnemy();
    [SerializeField] Shoot Shoot;

    float elapsed = 1;
    Touch touch;
    private void Awake()
    {
        shootEvent += ShootReady;
    }

    private void FixedUpdate()
    {
        elapsed += Time.deltaTime;
        //if (closestEnemy == null) return;
        //closestEnemy.GetNearestEnemy(transform);
        //var closest = closestEnemy.nearestEnemy;

        if (/*Input.touchCount > 0 &&*/ elapsed >= 1f /*&& closestEnemy.nearestEnemy != null*/ && Shoot.Instance._bulletType != null)
        {
            shootEvent?.Invoke();
            elapsed = elapsed % 1;
        }
    }

    void ShootReady()
    {
        Shoot.Fire(this);
    }

}





