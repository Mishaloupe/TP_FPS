using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField] Dragon player;
    [SerializeField] bool trueFalse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    public void changeAnim(string anim)
    {
        player.actualAnimator.SetTrigger(anim);
    }

    public void SetTrueFalse(bool value)
    {
        trueFalse = value;
    }

    public void changeAnimBool(string anim)
    {
        player.actualAnimator.SetBool(anim, trueFalse);
    }
}
 