using UnityEngine;
[System.Serializable]

public abstract class Effect : ScriptableObject
{
    public abstract GameAction GetGameAction();
}
