using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Wall;
    public float TimeSpawn;
    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    
    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(Wall, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
