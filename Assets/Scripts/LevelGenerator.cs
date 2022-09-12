using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    private readonly List<GameObject> activeTiles = new();
    private float spawnPos = 0;
    [SerializeField] private float tileLength = 45;

    [SerializeField] private Transform player;
    [SerializeField] private int startTilesCount = 2;

    void Start()
    {
        LevelInitialization();
    }

    private void LevelInitialization()
    {
        SpawnTile(0);
        for (int i = 1; i < startTilesCount; i++)
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    void Update()
    {
        if (player.position.z - 45 > spawnPos - (startTilesCount * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }
    }

    private void SpawnTile(int tileIndex)
    {
        GameObject nextTile = Instantiate(tilePrefabs[tileIndex], transform.forward * spawnPos, transform.rotation);
        activeTiles.Add(nextTile);
        spawnPos += tileLength;
    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
