using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiner : MonoBehaviour
{
    [SerializeField] private float _speedOfTurnByY;
    private float _speedOfTurnByX = 0;
    private float _speedOfTurnByZ = 0;

    private void Update()
    {
        transform.Rotate(_speedOfTurnByX, _speedOfTurnByY, _speedOfTurnByZ);
    }
}