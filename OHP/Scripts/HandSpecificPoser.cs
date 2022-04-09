using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyButtons;

public class HandSpecificPoser : MonoBehaviour
{
    public Transform[] Thumb;
    public Transform[] Index;
    public Transform[] Middle;
    public Transform[] Ring;
    public Transform[] Pinky;

    public HandSpecficiPoserSO pose;

    [Button]
    public void SavePose()
    {
        pose.Thumb = new Quaternion[Thumb.Length];
        pose.Index = new Quaternion[Index.Length];
        pose.Middle = new Quaternion[Middle.Length];
        pose.Ring = new Quaternion[Ring.Length];
        pose.Pinky = new Quaternion[Pinky.Length];

        for (int i = 0; i < Thumb.Length; i++)
        {
            pose.Thumb[i] = Thumb[i].localRotation;
        }

        for (int i = 0; i < Index.Length; i++)
        {
            pose.Index[i] = Index[i].localRotation;
        }

        for (int i = 0; i < Middle.Length; i++)
        {
            pose.Middle[i] = Middle[i].localRotation;
        }

        for (int i = 0; i < Ring.Length; i++)
        {
            pose.Ring[i] = Ring[i].localRotation;
        }

        for (int i = 0; i < Pinky.Length; i++)
        {
            pose.Pinky[i] = Pinky[i].localRotation;
        }
    }

    [Button]
    public void LoadPose()
    {
        for (int i = 0; i < Thumb.Length; i++)
        {
            Thumb[i].localRotation = pose.Thumb[i];
        }

        for (int i = 0; i < Index.Length; i++)
        {
            Index[i].localRotation = pose.Index[i];
        }

        for (int i = 0; i < Middle.Length; i++)
        {
            Middle[i].localRotation = pose.Middle[i];
        }

        for (int i = 0; i < Ring.Length; i++)
        {
            Ring[i].localRotation = pose.Ring[i];
        }

        for (int i = 0; i < Pinky.Length; i++)
        {
            Pinky[i].localRotation = pose.Pinky[i];
        }
    }
}
