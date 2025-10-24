using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class NewMonoBehaviourScript : MonoBehaviour
{
    List<GameObject> gos = new();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveObject()
    {
        GameObject[] go = GameObject.FindGameObjectsWithTag("Sphere");
        foreach (GameObject game in go)
        {
            if (!gos.Contains(game))
            {
                gos.Add(game);
            }
        }
        foreach (GameObject game in gos)
        {
            game.SetActive(!game.activeInHierarchy);
        }
    }
}
