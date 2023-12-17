using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHasProgress
{
    public event EventHandler<OnprogressChangedEventargs> OnprogressChanged;

    public class OnprogressChangedEventargs : EventArgs
    {
        public float progressNormalized;
    }
}