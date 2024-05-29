using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speedByX = 0;
    private float _speedByY = 0;
    private float _speedByZ = 0.25f;

    private void Update()
    {
        transform.Translate(_speedByX, _speedByY, _speedByZ);
    }
}