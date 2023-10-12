using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pose", menuName = "OpenHandPoser/HandPose Object", order = 1)]
public class HandSpecficiPoserSO : ScriptableObject
{
    public Quaternion[] Thumb;
    public Quaternion[] Index;
    public Quaternion[] Middle;
    public Quaternion[] Ring;
    public Quaternion[] Pinky;
}
