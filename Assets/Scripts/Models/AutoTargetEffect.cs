using UnityEngine;
[System.Serializable]
public class AutoTargetEffect 
{
    [field: SerializeField] public TargetMode TargetMode { get; private set; }
    [field: SerializeField] public Effect Effect { get; private set; }
}
