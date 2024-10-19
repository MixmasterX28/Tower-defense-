using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject _PlayerBomb;

    private float CooldownPLR;
    bool cooldownActivePLR = true;
    private Renderer rendPlayer;
    private Color CooldownOffColor = new Color (1f, 1f, 1f, 0.5f);
    private Color CooldownOnColor = new Color (1f, 1f, 1f, 1f);

    // Start is called before the first frame update
    void Start()
    {
        _PlayerBomb.SetActive(false);
        rendPlayer = GetComponent<Renderer>();
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
        yield return new WaitForSeconds(5);
        _PlayerBomb.SetActive(false);
        cooldownActivePLR = false;
        rendPlayer.material.color = CooldownOffColor;
        yield return new WaitForSeconds(5);
        cooldownActivePLR = true;
        rendPlayer.material.color= CooldownOnColor;
    }
}
