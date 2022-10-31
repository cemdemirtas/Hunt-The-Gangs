using System;
using UnityEngine;
using System.Collections;



public class Missile : MonoBehaviour
{
    Rigidbody rb;
    int speed = 20;

    public Rigidbody _rb { get => rb; set => rb = value; }
    public int _speed { get => speed; set => speed = value; }

    private void Update()
    {
    }
    private void OnEnable()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = transform.TransformDirection(Vector3.forward * _speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out IExplode ex))
        {
            ex.Explode();
        }
        //gameObject.SetActive(false);
        if (other.gameObject.tag == "LastWall") gameObject.SetActive(false);
    }
}
