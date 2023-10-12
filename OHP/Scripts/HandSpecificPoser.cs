using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyButtons;

[ExecuteInEditMode]
public class HandSpecificPoser : MonoBehaviour
{
    [Header("HandPoser Settings")]
    public Hand leftHand;
    public Hand rightHand;
    public HandSpecficiPoserSO pose;

    [Header("Utilities")]
    public bool TrackHandsToPoints;
    public Transform leftHandPoint;
    public Transform rightHandPoint;

    [System.Serializable]
    public struct Hand
    {
        public Transform HandRoot;
        public Transform[] Thumb;
        public Transform[] Index;
        public Transform[] Middle;
        public Transform[] Ring;
        public Transform[] Pinky;

        public void SavePose(HandSpecficiPoserSO pose)
        {
            AssignBonePose(Thumb, pose.Thumb, true);
            AssignBonePose(Index, pose.Index, true);
            AssignBonePose(Middle, pose.Middle, true);
            AssignBonePose(Ring, pose.Ring, true);
            AssignBonePose(Pinky, pose.Pinky, true);
        }

        public void LoadPose(HandSpecficiPoserSO pose)
        {
            AssignBonePose(Thumb, pose.Thumb, false);
            AssignBonePose(Index, pose.Index, false);
            AssignBonePose(Middle, pose.Middle, false);
            AssignBonePose(Ring, pose.Ring, false);
            AssignBonePose(Pinky, pose.Pinky, false);
        }

        public void SetPose(Hand hand)
        {
            AssignBonePose(Thumb, hand.Thumb, false);
            AssignBonePose(Index, hand.Index, false);
            AssignBonePose(Middle, hand.Middle, false);
            AssignBonePose(Ring, hand.Ring, false);
            AssignBonePose(Pinky, hand.Pinky, false);
        }
    }

#region Main Functions
    public void Update()
    {
        if (leftHandPosition && rightHandPosition
        {
            TrackHandsToPoints();
        }
    }

    [Button]
    public void SavePose()
    {
        leftHand.SavePose(pose);
        rightHand.SavePose(pose);
    }

    [Button]
    public void LoadPose()
    {
        leftHand.LoadPose(pose);
        rightHand.LoadPose(pose);
    }

    [Button]
    public void MirrorLeftToRight()
    {
        rightHand.SetPose(leftHand);
    }

    [Button]
    public void MirrorRightToLeft()
    {
        leftHand.SetPose(rightHand);
    }

    public void TrackHandsToPoints()
    {
        leftHand.HandRoot.position = leftHandPosition.position;
        leftHand.HandRoot.rotation = leftHandPosition.rotation;

        rightHand.HandRoot.position = rightHandPosition.position;
        rightHand.HandRoot.rotation = rightHandPosition.rotation;
    }
#endregion

#region Utilities
    Quaternion MirrorBoneFix(Quaternion quat)
    {
        return new Quaternion(quat.x, quat.y * -1f, quat.z * -1f, quat.w);
    }

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
#endregion
}
