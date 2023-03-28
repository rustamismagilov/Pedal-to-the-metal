using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    RoadSpawner roadSpawner;
    //SideSpawner sideSpawner;

    // Start is called before the first frame update
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        //sideSpawner = GetComponent<SideSpawner>();
    }

    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        //sideSpawner.SpawnSide();
    }
}
