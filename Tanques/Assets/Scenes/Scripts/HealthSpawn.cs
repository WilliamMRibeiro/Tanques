using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawn : MonoBehaviour
{
    public GameObject Health;
    public float time = 0f;
    public float timeMax;
    public float timeMin;
    public float xposMin;
    public float xposMax;
    public float zposMax;
    public float zposMin;

    private void Update()
    {
        time += Time.deltaTime;
        float timeLimit = Random.Range(timeMin, timeMax);

        if (time >= timeLimit)
        {
            float randomX = Random.Range(xposMin, xposMax);
            float randomZ = Random.Range(zposMin, zposMax);
            GameObject instaLife = Instantiate(Health, new Vector3(randomX, 0.5f, randomZ), Quaternion.identity) as GameObject;

            time = 0;
        }
    }
}
