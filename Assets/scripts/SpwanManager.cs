using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    // Start is called before the first frame update\
    public GameObject[]animalPrefabs;
    private float gameSpwanposz=20f;
    private float gameSpwanRange=20f;
    private float start=2.0f;
    private float timeDelay=1.5f;

    void Start()
    {
        InvokeRepeating("SpwanRAndomAnimal",start,timeDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void SpwanRAndomAnimal(){
            int gameIndex=Random.Range(0,animalPrefabs.Length);
            Vector3 spawnVector=new Vector3(Random.Range(-gameSpwanRange,gameSpwanRange),0,gameSpwanposz);
            Instantiate(animalPrefabs[gameIndex],spawnVector,animalPrefabs[gameIndex].transform.rotation);
        }
}
