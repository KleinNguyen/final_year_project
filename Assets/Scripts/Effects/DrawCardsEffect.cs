using UnityEngine;

public class DrawCardsEffect : Effect
{
    [SerializeField]
    private int drawAmount = 1;

    public override GameAction GetGameAction()
    {
        DrawCardGA drawCardsGA = new(drawAmount);
        return drawCardsGA;
    }
}