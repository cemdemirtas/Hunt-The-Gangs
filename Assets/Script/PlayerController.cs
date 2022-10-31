using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float mouseposX;
    private float horizontalSpeed = 5;
    private Vector3 rayHitWorldPosition;

    public float _horizontalSpeed { get => horizontalSpeed; set => horizontalSpeed = value; }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            // raycast
            RaycastHit rayHit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity))
            {
                // where did the raycast hit in the world - position of rayhit
                rayHitWorldPosition = rayHit.point;
                mouseposX = rayHit.point.x;
            }
            Vector3 moveOnX = new Vector3(mouseposX, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, moveOnX, _horizontalSpeed * Time.deltaTime);
        }
    }
}
