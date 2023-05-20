using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform Objetive;
    public float Speed;
    public NavMeshAgent AI;
    public Animation Anim;
    public string Walk;
    public string Attack;

    // Update is called once per frame
    void Update()
    {
        AI.speed = Speed;
        AI.SetDestination(Objetive.position);
        if(AI.velocity == Vector3.zero)
        {
            Anim.CrossFade(Attack);
        }
        else
        {
            Anim.CrossFade(Walk);
        }
    }
}
