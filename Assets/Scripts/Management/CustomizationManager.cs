using UnityEngine;

public class CustomizationManager : MonoBehaviour
{
    [SerializeField] PlayerStatsScriptableObject _playerStatsSO;

    [SerializeField] SpriteRenderer[] _headSprites;
    [SerializeField] SpriteRenderer[] _bodySprites;
    [SerializeField] SpriteRenderer[] _glovesSprites;
    [SerializeField] SpriteRenderer[] _pantsSprites;
    [SerializeField] SpriteRenderer[] _bootsSprites;

    public void UpdateHeadSkin()
    {
        _headSprites[0].sprite = _playerStatsSO.currentHeadSo.partsSprites[0];
        _headSprites[1].sprite = _playerStatsSO.currentHeadSo.partsSprites[1];
        _headSprites[2].sprite = _playerStatsSO.currentHeadSo.partsSprites[2];
    }
}
