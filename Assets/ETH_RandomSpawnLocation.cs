using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETH_RandomSpawnLocation : MonoBehaviour
{

    public float lowerBoundX;
    public float lowerBoundY;
    public float lowerBoundZ;
    public float upperBoundX;
    public float upperBoundY;
    public float upperBoundZ;

    // Start is called before the first frame update
    void Awake()
    {
        this.gameObject.transform.position = new Vector3 (
            Random.Range(lowerBoundX, upperBoundX),
            Random.Range(lowerBoundY, upperBoundY),
            Random.Range(lowerBoundZ, upperBoundZ)
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
