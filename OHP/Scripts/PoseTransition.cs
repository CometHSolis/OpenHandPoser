using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseTransition : MonoBehaviour
{
    public PoserSO one;
    public PoserSO two;

    public Poser poser;

    [Range(0, 1)]
    public float progress;

    void Update()
    {
        for (int i = 0; i < poser.Bones.Length; i++)
        {
            poser.Bones[i].localRotation = Quaternion.Lerp(one.Bones[i], two.Bones[i], progress);
        }
    }
}
