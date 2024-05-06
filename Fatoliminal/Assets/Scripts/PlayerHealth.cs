using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float value = 100;
    private float _maxValue;
    public GameObject gameplayUI;
    // Start is called before the first frame update
    void Start()
    {
        _maxValue = value;
    }

    // Update is called once per frame

    void Update()
    {
 
    }

    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            PlayerIsDead();
        }
    }

    private void PlayerIsDead()
    {
        gameplayUI.SetActive(false);
        GetComponent<PlayerController>().enabled = false;
        GetComponent<CameraRotation>().enabled = false;
    }  
}



