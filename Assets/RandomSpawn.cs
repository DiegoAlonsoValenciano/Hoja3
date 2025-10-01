using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float x = 0;
        float y = 0;
        float z = 0;

        x = Random.Range(-10, 10);
        y = Random.Range(-10, 10);
        z = Random.Range(-10, 10);

        transform.position = new Vector3(x,y,z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
