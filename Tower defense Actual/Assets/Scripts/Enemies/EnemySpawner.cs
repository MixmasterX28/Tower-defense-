using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] public GameObject Spawner;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Endless", 4, 2);
    }

    void Endless() 
    {
        Instantiate(Spawner);
    }

}
