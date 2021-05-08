using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    [SerializeField] private GameObject _ball;

    private void Start()
    {
        Instantiate(_ball, transform.position, Quaternion.identity);
    }
}
