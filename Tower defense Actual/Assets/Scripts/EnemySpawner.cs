using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] public GameObject Spawner;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Endless", 5, 1);
    }

    void Endless() 
    {
        Instantiate(Spawner);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
