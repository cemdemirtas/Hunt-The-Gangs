using UnityEngine.AI;

internal interface IMovable
{
    void Move(NavMeshAgent nav,bool OnNav);
}