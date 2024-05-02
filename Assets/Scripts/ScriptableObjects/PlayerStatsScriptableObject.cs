using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "PlayerStats")]
public class PlayerStatsScriptableObject : ScriptableObject
{
    public int coins = 0;
    public BodyPartScriptableObject currentHeadSo;
    public BodyPartScriptableObject currentBodySo;
    public BodyPartScriptableObject currentGlovesSo;
    public BodyPartScriptableObject currentPantsSo;
    public BodyPartScriptableObject currentBootsSo;

    [Header("Default Skin")]
    public BodyPartScriptableObject defaultHeadSo;
    public BodyPartScriptableObject defaultBodySo;
    public BodyPartScriptableObject defaultGlovesSo;
    public BodyPartScriptableObject defaultPantsSo;
    public BodyPartScriptableObject defaultBootsSo;

    public void AddCoins(int coinsToAdd) => coins += coinsToAdd;
    public void RemoveCoins(int coinsToRemove) => coins -= coinsToRemove;
    public void ResetCoins() => coins = 0;
}
