using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redirector : MonoBehaviour
{
    public int changeNumber = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            changeNumber += 1;
            if (changeNumber >= 4) { changeNumber = 1; };
            if (changeNumber == 1) { collision.gameObject.tag = ("lane1"); };
            if (changeNumber == 2) { collision.gameObject.tag = ("lane2"); };
            if (changeNumber == 3) { collision.gameObject.tag = ("lane3"); };
        }

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            if (changeNumber == 1) { collision.gameObject.tag = ("lane1"); };
            if (changeNumber == 2) { collision.gameObject.tag = ("lane2"); };
            if (changeNumber == 3) { collision.gameObject.tag = ("lane3"); };
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
