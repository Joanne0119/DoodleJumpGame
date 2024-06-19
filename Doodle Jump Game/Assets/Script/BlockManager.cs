using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    [SerializeField] GameObject[] BlockPrefabs;

    public void SpawnBlock(){
        int r = Random.Range(0, BlockPrefabs.Length);
        GameObject block = Instantiate(BlockPrefabs[r], transform);
        block.transform.position = new Vector3(Random.Range(-3.7f, 3.7f), -6f, 0f);
    } 
}
