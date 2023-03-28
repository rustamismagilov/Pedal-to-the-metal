/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideSpawner : MonoBehaviour
{

    private int initAmount = 8;
    private float sideSize = 0.0025f;
    private float xPosLeft = 0f;
    private float xPosRight = 0f;
    private float lastZPos = 0f;

    public List<GameObject> sides;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initAmount; i++)
        {
            SpawnSide();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnSide()
    {
        GameObject sideLeft = sides[Random.Range(0, sides.Count)];
        GameObject sideRight = sides[Random.Range(0, sides.Count)];

        float zPos = lastZPos + sideSize;

        Instantiate(sideLeft, new Vector3(xPosLeft, 0.025f, zPos), sideLeft.transform.rotation);
        Instantiate(sideRight, new Vector3(xPosRight, 0.025f, zPos), new Quaternion(0, 180, 0, 0));

        lastZPos += sideSize;
    }
}
*/
