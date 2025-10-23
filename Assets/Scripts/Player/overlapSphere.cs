using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class overlapSphere : MonoBehaviour
{
    public List<GameObject> listOfGameObject;
    public TextMeshProUGUI textmesh;
    public int rayon;
    public void GetArray()
    {
        listOfGameObject.Clear();
        textmesh.text = "Pas de collider sur les dragons \n";
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, rayon);
        foreach (var hitCollider in hitColliders)
        {
            listOfGameObject.Add(hitCollider.gameObject);
            textmesh.text += hitCollider.gameObject.name + "\n";
        }
    }
}
