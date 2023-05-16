using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Enemy : MonoBehaviour
{
    public Transform spawnpos;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject Enemy;
    
    private void Start()
    {
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(5.8f);
        Vector2 pos = spawnpos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(Enemy, pos, Quaternion.identity);
        Repeat();
    }
    void Repeat ()
    {
        StartCoroutine(Spawn());
    }


}
