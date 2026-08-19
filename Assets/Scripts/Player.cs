using UnityEngine;


[CreateAssetMenu(fileName = "New Player", menuName = "Player")]
public class Player : ScriptableObject
{
    public string playerName;
    //public string playerDescription;
    public int maxHealth;
    public int maxEnergy;

}
