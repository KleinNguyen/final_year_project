using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardData : ScriptableObject
{
    [field: SerializeField] public string cardName { get;  private set; }
    [field: SerializeField] public string cardDescription { get; private set; }
    [field: SerializeField] public int Energy { get; private set; }
    [field: SerializeField] public Effect ManualTargetEffect { get; private set; } = null;
    [field: SerializeField] public List<AutoTargetEffect> OtherEffects { get; private set; } = null;


}