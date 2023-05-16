using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Bonus : MonoBehaviour
{
    public Transform spawnpos;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject Bonus;
    
    private void Start()
    {
        StartCoroutine(Spawn());
    }


    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(3.4f);
        Vector2 pos = spawnpos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(Bonus, pos, Quaternion.identity);
        Repeat();
    }
    void Repeat ()
    {
        StartCoroutine(Spawn());
    }


}
