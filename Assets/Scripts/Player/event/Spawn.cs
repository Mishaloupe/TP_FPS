using UnityEngine;

public class Spawn : MonoBehaviour
{
    Vector3 pos = new Vector3(0, 10.0f, -40.0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObject(GameObject go)
    {
        Instantiate(go, pos, Quaternion.identity);
    }
}
