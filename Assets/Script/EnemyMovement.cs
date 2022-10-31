using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement :MonoBehaviour, IMovable
{
    private NavMeshAgent nav;
    public NavMeshAgent _nav { get => nav; set => nav = value; }
    [SerializeField] EnemySO _enemySO;
    [SerializeField] private Transform Player;
    private bool _onNav = true;

    public void Move(NavMeshAgent nav, bool OnNav)
    {
        nav.speed = _enemySO.speed;
        nav.enabled = _onNav;
        nav.SetDestination(Player.position);
    }

    void OnEnable()
    {
        Player = GameObject.Find("Player").transform;
        _nav =GetComponent<NavMeshAgent>();
    }

    void Update()
    {
       if(Player!=null) Move(_nav, _onNav);

    }
}
