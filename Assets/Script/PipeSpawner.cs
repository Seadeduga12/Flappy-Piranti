using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 0f, spawnInterval);
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(-2f, 2f);
        Instantiate(pipePrefab, new Vector3(10f, randomY, 0f), Quaternion.identity);
    }
}
