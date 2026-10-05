using UnityEngine;

public class HeroView : CombatantView
{
    public void Setup(PlayerData heroData)
    {
        SetupBase(heroData.Health, heroData.Image);
    }
}
