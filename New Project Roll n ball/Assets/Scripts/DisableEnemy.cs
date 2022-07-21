using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]
public class DisableEnemy : MonoBehaviour
{

    public enum Mode { DisableEnemy, EnableEnemy }

    [SerializeField] Mode ThisObject;
    [SerializeField] EnemyFollow[] Enemies;

    void Awake ()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }
     void OnTriggerEnter ()
     {
        if (ThisObject == Mode.DisableEnemy) 
        {
            foreach (EnemyFollow enemy in Enemies) enemy.enabled = false;
        }
        else if (ThisObject == Mode.EnableEnemy)
        {
            foreach (EnemyFollow enemy in Enemies) enemy.enabled = true;
        }
    }
}
