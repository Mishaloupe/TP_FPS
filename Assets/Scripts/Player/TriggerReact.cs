using UnityEngine;

public class TriggerReact : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void OnTriggerExit(Collider other)
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
