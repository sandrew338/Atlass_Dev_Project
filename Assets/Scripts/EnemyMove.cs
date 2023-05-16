using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    GameObject Enemy;
    [SerializeField]
    float speed;
    void FixedUpdate()
    {
        Enemy.transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
    