using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGeneration : MonoBehaviour
{
    public GameObject coinPrefab;
    public Transform[] coinPositions = new Transform[6];
    // Start is called before the first frame update
    void Start()
    {
        SpawnCoins();
    }

    void SpawnCoins()
    {
        for (int i = 0; i < coinPositions.Length; i++)
        {
            GameObject temp = Instantiate(coinPrefab);
            temp.transform.position = coinPositions[i].position;
        }
    }
}
