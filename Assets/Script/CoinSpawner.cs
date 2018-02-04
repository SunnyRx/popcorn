using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    public GameObject CoinFly;
    public GameObject CoinHeart;
    public GameObject CoinBomb;
    public GameObject CoinClock;
    public float WaveTimer = 5f;

    private void Update()
    {
        WaveTimer -= Time.deltaTime;
        if (WaveTimer <= 0)
        {
            PickRandomCoin();
            ResetWave();
        }
    }

    private void ResetWave()
    {
        WaveTimer = 11f;
    }

    private void PickRandomCoin()
    {
        Vector3 SpawnPoint = new Vector3(Random.Range(-13.0f, 13.0f), 29.0f, -9.8f);
        int roll = Random.Range(1, 101);
        if(roll < 26)
        {
            Instantiate(CoinFly, SpawnPoint, Quaternion.identity);
        }
        else if (roll > 25 && roll < 51)
        {
            Instantiate(CoinHeart, SpawnPoint, Quaternion.identity);
        }
        else if (roll > 50 && roll < 76)
        {
            Instantiate(CoinBomb, SpawnPoint, Quaternion.identity);
        }
        else if (roll > 75)
        {
            Instantiate(CoinClock, SpawnPoint, Quaternion.identity);
        }
        else
        {
            return;
        }

    }
}
