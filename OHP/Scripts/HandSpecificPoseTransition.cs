using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSpecificPoseTransition : MonoBehaviour
{
    public HandSpecficiPoserSO one;
    public HandSpecficiPoserSO two;

    public HandSpecificPoser poser;

    [Range(0, 1)]
    public float progressThumb;

    [Range(0, 1)]
    public float progressIndex;

    [Range(0, 1)]
    public float progressMiddle;

    [Range(0, 1)]
    public float progressRing;

    [Range(0, 1)]
    public float progressPinky;

    void Update()
    {
        for (int i = 0; i < poser.Thumb.Length; i++)
        {
            poser.Thumb[i].localRotation = Quaternion.Lerp(one.Thumb[i], two.Thumb[i], progressThumb);
        }

        for (int i = 0; i < poser.Index.Length; i++)
        {
            poser.Index[i].localRotation = Quaternion.Lerp(one.Index[i], two.Index[i], progressIndex);
        }

        for (int i = 0; i < poser.Middle.Length; i++)
        {
            poser.Middle[i].localRotation = Quaternion.Lerp(one.Middle[i], two.Middle[i], progressMiddle);
        }

        for (int i = 0; i < poser.Ring.Length; i++)
        {
            poser.Ring[i].localRotation = Quaternion.Lerp(one.Ring[i], two.Ring[i], progressRing);
        }

        for (int i = 0; i < poser.Pinky.Length; i++)
        {
            poser.Pinky[i].localRotation = Quaternion.Lerp(one.Pinky[i], two.Pinky[i], progressPinky);
        }
    }
}
