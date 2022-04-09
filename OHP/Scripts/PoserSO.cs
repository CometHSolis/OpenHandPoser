using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pose", menuName = "OpenHandPoser/Pose Object", order = 1)]
public class PoserSO : ScriptableObject
{
    public Quaternion[] Bones;
}
