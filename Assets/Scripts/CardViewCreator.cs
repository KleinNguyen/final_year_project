using DG.Tweening;
using UnityEngine;

public class CardViewCreator : Singleton<CardViewCreator>
{
    [SerializeField] private CardView cardViewPreFab;
    public CardView CreateCardView(Vector3 position, Quaternion rotation)
    {   
        CardView cardView = Instantiate(cardViewPreFab, position, rotation);
        cardView.transform.localScale = Vector3.zero;
        cardView.transform.DOScale(Vector3.one, 0.15f);
        return cardView;
    }

}
