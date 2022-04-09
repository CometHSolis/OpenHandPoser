using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyButtons;
using UnityEditor;

public class Poser : MonoBehaviour
{
    public Transform[] Bones;

    public PoserSO pose;

    [Button]
    public void SavePose()
    {
        pose.Bones = new Quaternion[Bones.Length];
        for (int i = 0; i < Bones.Length; i++)
        {
            pose.Bones[i] = Bones[i].localRotation;
        }
    }

    [Button]
    public void LoadPose()
    {
        for (int i = 0; i < Bones.Length; i++)
        {
            Bones[i].localRotation
                = pose.Bones[i];
        }
    }

    
}
