using System.Collections;
using Defense.Manager;
using UnityEngine;

namespace Defense
{
    public class SpawnPoint : MonoBehaviour
    {
        public float spawnRate = 1f;
        public GameObject monsterPrefab;

        private Coroutine _spawnCoroutine;

        void Start()
        {
            EventManager.Instance.On("onGameStart", Spawn);
            EventManager.Instance.On("onGamePaused", StopSpawn);
        }

        void Spawn(object param)
        {
            _spawnCoroutine = StartCoroutine(SpawnRoutine());
        }

        void StopSpawn(object param)
        {
            StopCoroutine(_spawnCoroutine);
        }

        IEnumerator SpawnRoutine()
        {
            while (true)
            {
                ObjectPoolManager.Instance.Spawn("monster", transform.position);
                yield return new WaitForSeconds(spawnRate);
            }
        }
    }
}