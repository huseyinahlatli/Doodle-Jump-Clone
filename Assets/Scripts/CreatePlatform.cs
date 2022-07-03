using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlatform : MonoBehaviour
{
    public GameObject platformPrefab;
    [SerializeField] int platformNumber = 200;

    void Start()
    {
        InstantiatePlatform();
    }

    void InstantiatePlatform()
    {
        Vector2 platformHeight = new Vector2();
        for(int j=0; j<platformNumber; j++)
        {
            GameObject tempPlatform = Instantiate(platformPrefab);
            platformHeight.x = Random.Range(-2.2f, 2.2f);
            platformHeight.y += Random.Range(1.6f, 2.0f);
            tempPlatform.transform.position = platformHeight;
        }
    }
}
