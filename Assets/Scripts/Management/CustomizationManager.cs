using UnityEngine;

public class CustomizationManager : MonoBehaviour
{
    #region Variables
    [SerializeField] PlayerStatsScriptableObject _playerStatsSO;

    [SerializeField] SpriteRenderer[] _headSprites;
    [SerializeField] SpriteRenderer[] _bodySprites;
    [SerializeField] SpriteRenderer[] _glovesSprites;
    [SerializeField] SpriteRenderer[] _pantsSprites;
    [SerializeField] SpriteRenderer[] _bootsSprites;
    #endregion
    #region PublicMethods
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

    public void ResetHeadSkin()
    {
        _headSprites[0].sprite = _playerStatsSO.defaultHeadSo.partsSprites[0];
        _headSprites[1].sprite = _playerStatsSO.defaultHeadSo.partsSprites[1];
        _headSprites[2].sprite = _playerStatsSO.defaultHeadSo.partsSprites[2];
    }

    public void ResetBodySkin()
    {
        _bodySprites[0].sprite = _playerStatsSO.defaultBodySo.partsSprites[0];
        _bodySprites[1].sprite = _playerStatsSO.defaultBodySo.partsSprites[1];
        _bodySprites[2].sprite = _playerStatsSO.defaultBodySo.partsSprites[2];
    }

    public void ResetGlovesSkin()
    {
        _glovesSprites[0].sprite = _playerStatsSO.defaultGlovesSo.partsSprites[0];
        _glovesSprites[1].sprite = _playerStatsSO.defaultGlovesSo.partsSprites[1];
        _glovesSprites[2].sprite = _playerStatsSO.defaultGlovesSo.partsSprites[2];
        _glovesSprites[3].sprite = _playerStatsSO.defaultGlovesSo.partsSprites[3];
    }

    public void ResetPantsSkin()
    {
        _pantsSprites[0].sprite = _playerStatsSO.defaultPantsSo.partsSprites[0];
        _pantsSprites[1].sprite = _playerStatsSO.defaultPantsSo.partsSprites[1];
        _pantsSprites[2].sprite = _playerStatsSO.defaultPantsSo.partsSprites[2];
    }

    public void ResetBootsSkin()
    {
        _bootsSprites[0].sprite = _playerStatsSO.defaultBootsSo.partsSprites[0];
        _bootsSprites[1].sprite = _playerStatsSO.defaultBootsSo.partsSprites[1];
    }
    #endregion
}
