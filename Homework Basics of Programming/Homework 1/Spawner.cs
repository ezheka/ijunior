using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _delaySpawn;
    [SerializeField] private GameObject _coin;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            SpawnObject();
            yield return new WaitForSeconds(_delaySpawn);
        }
    }

    private void SpawnObject()
    {
        int _randomIdSpawnPoint = Random.Range(0, _spawnPoints.Length);
        Instantiate(_coin, _spawnPoints[_randomIdSpawnPoint].position, Quaternion.identity);
    }
}
