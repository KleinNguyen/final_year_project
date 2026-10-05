using UnityEngine;
using System.Collections.Generic;

public class Card 
{
    public string Title => data.cardName;
    public string Description => data.cardDescription;
    public Effect ManualTargetEffecct => data.ManualTargetEffect;
    public List<AutoTargetEffect> OtherEffects => data.OtherEffects;
    public int Energy {get; private set; }
    private readonly CardData data;
    public Card(CardData cardData)
    {
        this.data = cardData;
        Energy = cardData.Energy;
    }
}
