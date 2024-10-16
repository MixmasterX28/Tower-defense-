using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject _PlayerBomb;

    private float CooldownPLR;
    bool cooldownActivePLR = true;

    // Start is called before the first frame update
    void Start()
    {
        _PlayerBomb.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        CooldownPLR += Time.deltaTime;

        if (cooldownActivePLR == true && Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(TimerPLR());
        }
    }

    IEnumerator TimerPLR()
    {
        _PlayerBomb.SetActive(true);
        yield return new WaitForSeconds(4);
        _PlayerBomb.SetActive(false);
        cooldownActivePLR = false;
        yield return new WaitForSeconds(5);
        cooldownActivePLR = true;
    }
}
