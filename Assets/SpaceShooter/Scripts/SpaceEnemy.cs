using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceEnemy : MonoBehaviour, IDestructable
{
    [SerializeField] SpaceWeapons spaceweapons;
    [SerializeField] float minFireTime;
    [SerializeField] float maxFireTime;

    public int points;
    private float timer;

    void Start()
    {
        timer = Random.Range(minFireTime, maxFireTime);   
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0 && spaceweapons != null)
        {
            timer = Random.Range(minFireTime, maxFireTime);
            spaceweapons.Fire();
        }
    }
    public void Destroyed()
    {
        GameManager.Instance.Score += points;
    }
}
