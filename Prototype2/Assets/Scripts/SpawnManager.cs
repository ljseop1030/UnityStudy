using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    private float startDelay  =2;
    private float spawnInterval = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        // InvokeRepeating ( 함수명 , 처음 호출까지 기다리는 시간, 반복 간격)
        // 어떤 함수를 반복 호출해주는 기능
        // start에 작성함


    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        // Instantiate (복제할 오브젝트, 위치, 생성 시 회전값 (원래 프리팹의 회전값 호출한거임!) )
        // 회전 안 넣을 거면 Quaternion.identity 하면 됨   
    
    }
}
