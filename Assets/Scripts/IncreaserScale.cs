using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaserScale : MonoBehaviour
{
    [SerializeField] private float _speedIncreasement;

    private void Update()
    {
        transform.localScale += new Vector3(_speedIncreasement, _speedIncreasement, _speedIncreasement);
    }
}