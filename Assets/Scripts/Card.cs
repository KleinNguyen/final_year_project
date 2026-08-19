using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public int energyCost;
    public int damage;
    public int block;
}