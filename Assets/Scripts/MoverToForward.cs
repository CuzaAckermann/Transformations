using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverToForward : MonoBehaviour
{
    private float _speedMovement = 0.5f;

    private void Update()
    {
        transform.Translate(transform.forward * _speedMovement);
    }
}