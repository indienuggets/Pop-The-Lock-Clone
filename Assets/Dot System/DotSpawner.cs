using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotSpawner : MonoBehaviour
{
    public AnchoredMotor Motor;
    public GameObject DotPrefab;
    public GameObject StarredDotPrefab;
    public GameData GameData;

    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        RemoveDuplicates();

        var angle = Random.Range(GameData.MinSpawnAngle, GameData.MaxSpawnAngle);
        var go = Instantiate(SelectRandomDot(), Motor.transform.position, Quaternion.identity, transform);
        go.transform.RotateAround(transform.position, Vector3.forward, -angle * (int)Motor.Direction);
    }

    GameObject SelectRandomDot()
    {
        if (Random.value < 0.2)
        {
            return StarredDotPrefab;
        }
        else
        {
            return DotPrefab;
        }
    }

    void RemoveDuplicates()
    {
        var dots = GameObject.FindGameObjectsWithTag("Dot");
        foreach (var dot in dots)
        {
            Destroy(dot);
        }
    }
}
