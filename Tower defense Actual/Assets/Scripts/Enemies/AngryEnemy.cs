using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AngryEnemy : MonoBehaviour
{

    [SerializeField] public float walkSpeed = 2f;

    Vector3 differencefactor;
    Vector3 startpoint;
    Vector3 goingPoint;
    Vector3 Direction;

    [SerializeField] List<Transform> lane1 = new List<Transform>();
    [SerializeField] List<Transform> lane2 = new List<Transform>();
    [SerializeField] List<Transform> lane3 = new List<Transform>();
    [SerializeField] List<Transform> CurrentPath;

    int pointPosition;

    private void Start()
    {
        transform.position = CurrentPath[0].position;

        goingPoint = CurrentPath[pointPosition].position;
    }

    private void StartRunning ()
    {
        differencefactor = goingPoint - transform.position;
        Direction = differencefactor.normalized;

        transform.position += Direction * walkSpeed * Time.deltaTime;

        if (differencefactor.magnitude < 0.1) 
        {
            goingPoint = CurrentPath[pointPosition].position;
            pointPosition++;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartRunning(); 
        if (gameObject.CompareTag("lane1")) 
        {
            CurrentPath = lane1;
        }

        if (gameObject.CompareTag("lane2"))
        {
            CurrentPath = lane2;
        }

        if (gameObject.CompareTag("lane3"))
        {
            CurrentPath = lane3;
        }


    }
}




//Vector2 walking = new Vector2(0, -3) * walkSpeed * Time.deltaTime;
//transform.Translate(walking);