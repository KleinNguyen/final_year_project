using UnityEngine;
using System.Collections.Generic;


public class MatchSetupSystem : MonoBehaviour
{
    //[SerializeField] private List<CardData> deckData;
    [SerializeField] private PlayerData playerData;
    [SerializeField] private List<EnemyData> enemyDatas;


    private void Start()
    {
        HeroSystem.Instance.Setup(playerData);
        EnemySystem.Instance.Setup(enemyDatas);
        CardSystem.Instance.Setup(playerData.Deck);
        DrawCardGA drawCardGA = new(5);
        ActionSystem.Instance.Perform(drawCardGA);
    }
}
