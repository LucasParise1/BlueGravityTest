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

    public void UpdateBodySkin()
    {
        _bodySprites[0].sprite = _playerStatsSO.currentBodySo.partsSprites[0];
        _bodySprites[1].sprite = _playerStatsSO.currentBodySo.partsSprites[1];
        _bodySprites[2].sprite = _playerStatsSO.currentBodySo.partsSprites[2];
    }

    public void UpdateGlovesSkin()
    {
        _glovesSprites[0].sprite = _playerStatsSO.currentGlovesSo.partsSprites[0];
        _glovesSprites[1].sprite = _playerStatsSO.currentGlovesSo.partsSprites[1];
        _glovesSprites[2].sprite = _playerStatsSO.currentGlovesSo.partsSprites[2];
        _glovesSprites[3].sprite = _playerStatsSO.currentGlovesSo.partsSprites[3];
    }

    public void UpdatePantsSkin()
    {
        _pantsSprites[0].sprite = _playerStatsSO.currentPantsSo.partsSprites[0];
        _pantsSprites[1].sprite = _playerStatsSO.currentPantsSo.partsSprites[1];
        _pantsSprites[2].sprite = _playerStatsSO.currentPantsSo.partsSprites[2];
    }

    public void UpdateBootsSkin()
    {
        _bootsSprites[0].sprite = _playerStatsSO.currentBootsSo.partsSprites[0];
        _bootsSprites[1].sprite = _playerStatsSO.currentBootsSo.partsSprites[1];
    }
}
