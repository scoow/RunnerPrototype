using System.Collections.Generic;
using UnityEngine;

namespace TopEngineTeam
{
    /*
    Генерация начального уровня из startTilesCount тайлов
    Добавление новых тайлов в случайном порядке по мере движения игрока и удаление старых
    */

    public class LevelGenerator : MonoBehaviour
    {
        public GameObject[] tilePrefabs;
        private readonly List<GameObject> activeTiles = new();
        private float spawnPos = 0;

        private readonly float tileLength = 45;
        [SerializeField] private Transform player;
        [SerializeField] private int startTilesCount = 6;

        void Start()
        {
            LevelInitialization();
        }
        void Update()
        {
            SpawnNextTileAndDeleteFirst();
        }

        private void SpawnNextTileAndDeleteFirst()
        {
            if (player.position.z - 45 > spawnPos - (startTilesCount * tileLength))
            {
                SpawnTile(Random.Range(0, tilePrefabs.Length));
                DeleteFirstTile();
            }
        }

        private void LevelInitialization()
        {
            SpawnTile(0);
            for (int i = 1; i < startTilesCount; i++)
            {
                SpawnTile(Random.Range(0, tilePrefabs.Length));
            }
        }
        private void SpawnTile(int tileIndex)
        {
            GameObject nextTile = Instantiate(tilePrefabs[tileIndex], transform.forward * spawnPos, transform.rotation);
            activeTiles.Add(nextTile);
            spawnPos += tileLength;
        }
        private void DeleteFirstTile()
        {
            Destroy(activeTiles[0]);
            activeTiles.RemoveAt(0);
        }
    }
}
