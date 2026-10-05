using UnityEngine;

public class EndBtnUi : MonoBehaviour
{
    public void OnClick()
    {
        EnemyTurnGA enemyTurnGA = new();
        ActionSystem.Instance.Perform(enemyTurnGA);
    }
}
