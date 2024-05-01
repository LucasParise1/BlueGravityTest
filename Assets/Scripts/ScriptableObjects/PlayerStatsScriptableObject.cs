using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "PlayerStats")]
public class PlayerStatsScriptableObject : ScriptableObject
{
    public int coins = 0;

    public void AddCoins(int coinsToAdd) => coins += coinsToAdd;
    public void RemoveCoins(int coinsToRemove) => coins -= coinsToRemove;
    public void ResetCoins() => coins = 0;
}
