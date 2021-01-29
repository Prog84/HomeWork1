﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        SpawnBalls(_template, _spawnPoints);
    }

    private void SpawnBalls(GameObject template, Transform[] spawnPoints)
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Instantiate(template, spawnPoints[i].position, Quaternion.identity);
        }
    }
}
