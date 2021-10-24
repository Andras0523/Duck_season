using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Transform> spawnPoss;
    public static Spawner instance;
    public GameObject bird;
    IEnumerator Spawnbird()
    {
        yield return new WaitForSeconds(Random.Range(2,5));
        Spawn();
        StartCoroutine(Spawnbird());
    }

    private void Awake()
    {
        
        instance = this;
    }

    private void Start()
    {
        StartCoroutine(Spawnbird());
    }


    public void Spawn()
    {
        int random = Random.Range(0, spawnPoss.Count);
        GameObject bird_ = Instantiate(bird, this.gameObject.transform);
        bird_.transform.position = spawnPoss[random].position;
        bird_.transform.rotation = spawnPoss[random].rotation;
       Direction dir = spawnPoss[random].gameObject.GetComponent<SpawnPos>().spawnDirection;
        if (dir == Direction.left)
        {
            bird_.GetComponent<Bird>().Flip();
        }
        //else if (dir == Direction.both)
        //{
        //    int rnd = Random.Range(0, 2);
        //    if (rnd == 0)
        //    {
        //        bird_.GetComponent<Bird>().Flip();
        //    }
        //}
        

    }

}
