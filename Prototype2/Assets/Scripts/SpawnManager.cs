using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(animalPrefabs[animalIndex], new Vector3(0,0,20), animalPrefabs[animalIndex].transform.rotation);
            // Instantiate (복제할 오브젝트, 위치, 생성 시 회전값 (원래 프리팹의 회전값 호출한거임!) )
            // 회전 안 넣을 거면 Quaternion.identity 하면 됨   
        }
    }
}
