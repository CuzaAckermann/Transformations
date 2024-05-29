using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverSpinerIncreaser : MonoBehaviour
{
    private float _speedMovement = 0.5f;

    private float _speedTurnByX = 0;
    private float _speedTurnByY = 1f;
    private float _speedTurnByZ = 0;

    private float _speedIncreasement = 0.02f;

    private void Update()
    {
        transform.localScale += new Vector3(_speedIncreasement, _speedIncreasement, _speedIncreasement);
        transform.Rotate(_speedTurnByX, _speedTurnByY, _speedTurnByZ);
        transform.Translate(transform.forward * _speedMovement);
    }
}