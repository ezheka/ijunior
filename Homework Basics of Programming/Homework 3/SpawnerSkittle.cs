using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSkittle : MonoBehaviour
{
    [SerializeField] private GameObject _skittle;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        for(int i = 0; i<_spawnPoints.Length; i++)
        {
            Instantiate(_skittle, _spawnPoints[i].position, Quaternion.identity);
        }
    }
}
