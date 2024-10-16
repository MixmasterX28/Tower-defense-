using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nexus : MonoBehaviour
{

    [SerializeField] public float NexusHealth = 3;
    AngryEnemy angryEnemy;  
    // Start is called before the first frame update

    public void NexusTakeDamage(float damage)
    {
        NexusHealth -= damage;
    }

    // Update is called once per frame
    void Update()
    {
        if (NexusHealth <= 0)
        {
            SceneManager.LoadScene(sceneName: "Game over");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Attack"))
        {
            NexusTakeDamage(1);
        }
    }
}
