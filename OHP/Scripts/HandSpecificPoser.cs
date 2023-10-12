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

    public void AssignBonePose(Transform[] bones, Quaternion[] fileBones, bool save)
    {
        for (int i = 0; int < bones.Length; i++)
        {
            if (save)
            {
                if (i == 0)
                    fileBones = new Quaternion[bones.Length];
            
                 fileBones[i] = bones[i].localRotation;
            }
            else
            {
                 bones[i].localRotation = fileBones[i];
            }
        }
    }

    [Button]
    public void SavePose()
    {
        AssignBonePose(Thumb, pose.Thumb, true);
        AssignBonePose(Index, pose.Index, true);
        AssignBonePose(Middle, pose.Middle, true);
        AssignBonePose(Ring, pose.Ring, true);
        AssignBonePose(Pinky, pose.Pinky, true);
    }

    [Button]
    public void LoadPose()
    {
        AssignBonePose(Thumb, pose.Thumb, false);
        AssignBonePose(Index, pose.Index, false);
        AssignBonePose(Middle, pose.Middle, false);
        AssignBonePose(Ring, pose.Ring, false);
        AssignBonePose(Pinky, pose.Pinky, false);
    }

    Quaternion MirrorBoneFix(Quaternion quat)
    {
        return new Quaternion(quat.x, quat.y * -1f, quat.z * -1f, quat.w);
    }
}
