using UnityEngine;

public class raycastHit : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    [SerializeField] Transform pivot;
    GameObject go;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, pivot.right, out hit, 3, mask))
        {
            go = hit.collider.gameObject;
            hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        } else
        {
            if (go != null) 
                go.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        
    }
}
