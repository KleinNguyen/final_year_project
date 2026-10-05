using UnityEngine;

public class HeroSystem : Singleton<HeroSystem>
{
    [field: SerializeField] public HeroView HeroView { get; private set; }
    public void Setup(PlayerData heroData)
    {
        HeroView.Setup(heroData);
    }
}
