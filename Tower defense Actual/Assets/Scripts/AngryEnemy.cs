using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AngryEnemy : MonoBehaviour
{

    public float walkSpeed = 1f;

    


    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(Vector2.down * walkSpeed * Time.deltaTime);

        transform.position = Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
