using UnityEngine;
using System.Collections;

public class RandomDestination : MonoBehaviour
{
    public GameObject prefab;


    // Instantiate the prefab somewhere between -10.0 and 10.0 on the x-z plane 
    void Start()
    {
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 0, Random.Range(-10.0F, 10.0F));
        Instantiate(prefab, position, Quaternion.identity);

    }
}

