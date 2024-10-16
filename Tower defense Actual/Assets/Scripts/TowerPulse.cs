using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TowerPulse : MonoBehaviour
{
    [SerializeField] GameObject _AtkPulse;

    private float cooldown;
    bool cooldownActive = true;
    

    // Start is called before the first frame update
    void Start()
    {
        _AtkPulse.SetActive(false);
        
    }

    void Pulsing()
    {

        Invoke("PulseOn", 0);
        Invoke("PulseOff", 1);

        Debug.Log("Pulsing");
    }

    void PulseOn()
    {
        _AtkPulse.SetActive(true);
        Debug.Log("PulseOn");
    }

    void PulseOff()
    {
        _AtkPulse.SetActive(false);
        Debug.Log("PulseOff");
    }

    void ActiveTime()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldown += Time.deltaTime;

       if(cooldownActive == true && Input.GetKeyDown(KeyCode.Space)) 
        {
            InvokeRepeating("Pulsing", 0, 2);
            StartCoroutine(timer());
        }
    }
    IEnumerator timer() 
    {
        yield return new WaitForSeconds(5);
        CancelInvoke("Pulsing");
        cooldownActive = false;
        yield return new WaitForSeconds(10);
        cooldownActive = true;
    }
}
