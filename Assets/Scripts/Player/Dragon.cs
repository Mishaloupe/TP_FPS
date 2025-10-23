using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField] GameObject drag1;
    [SerializeField] GameObject drag2;
    [SerializeField] GameObject drag3;
    [SerializeField] GameObject drag4;
    public Dictionary<string, GameObject> dragonByName = new();
    [SerializeField] GameObject actualDragon;
    public Animator actualAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dragonByName["Drag1"] = drag1;
        dragonByName["Drag2"] = drag2;
        dragonByName["Drag3"] = drag3;
        dragonByName["Drag4"] = drag4;
        actualDragon = drag3;
        actualAnimator = actualDragon.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeDragon(string name)
    {
        actualDragon.SetActive(false);
        actualDragon = dragonByName[name];
        actualDragon.SetActive(true);
        actualAnimator = actualDragon.GetComponent<Animator>();
    }
}
