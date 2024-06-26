using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BodyPartButton : MonoBehaviour
{
    #region Variables
    [SerializeField] private string _bodyPartId;
    [SerializeField] private BodyPartScriptableObject _bodyPartSO;
    [SerializeField] private PlayerStatsScriptableObject _playerStatsSO;
    [SerializeField] private Image _bodyPartIcon;
    [SerializeField] private TextMeshProUGUI _priceText;
    [SerializeField] private GameObject _lockedStatus;
    [SerializeField] private GameObject _unlockedStatus;
    [SerializeField] private bool _buyButton;

    private CustomizationManager _customizationManager;
    private Shopkeeper _shopkeeper;
    private PlayerInfoUi _infoUi;
    #endregion
    #region Lifecycle
    private void Start()
    {
        _customizationManager = FindObjectOfType<CustomizationManager>();
        _infoUi = FindObjectOfType<PlayerInfoUi>();
        _shopkeeper = FindObjectOfType<Shopkeeper>();
        LoadSoData();
    }
    #endregion
    #region PrivateMethods
    private void LoadSoData()
    {
        _bodyPartIcon.sprite = _bodyPartSO.buttonIcon;
        _priceText.text = _bodyPartSO.price.ToString();
        CheckPurchase();
    }

    private void CheckId()
    {
        if (_bodyPartId == "Head")
        {
            _playerStatsSO.currentHeadSo = _bodyPartSO;
            _customizationManager.UpdateHeadSkin();
        }
        else if (_bodyPartId == "Body")
        {
            _playerStatsSO.currentBodySo = _bodyPartSO;
            _customizationManager.UpdateBodySkin();
        }
        else if (_bodyPartId == "Gloves")
        {
            _playerStatsSO.currentGlovesSo = _bodyPartSO;
            _customizationManager.UpdateGlovesSkin();
        }
        else if (_bodyPartId == "Pants")
        {
            _playerStatsSO.currentPantsSo = _bodyPartSO;
            _customizationManager.UpdatePantsSkin();
        }
        else if (_bodyPartId == "Boots")
        {
            _playerStatsSO.currentBootsSo = _bodyPartSO;
            _customizationManager.UpdateBootsSkin();
        }
    }

    private void CheckCurrentSkin()
    {
        if (_bodyPartId == "Head" && _playerStatsSO.currentHeadSo == _bodyPartSO)
        {
            _playerStatsSO.currentHeadSo = null;
            _customizationManager.ResetHeadSkin();
        }
        else if (_bodyPartId == "Body" && _playerStatsSO.currentBodySo == _bodyPartSO)
        {
            _playerStatsSO.currentBodySo = null;
            _customizationManager.ResetBodySkin();
        }
        else if (_bodyPartId == "Gloves" && _playerStatsSO.currentGlovesSo == _bodyPartSO)
        {
            _playerStatsSO.currentGlovesSo = null;
            _customizationManager.ResetGlovesSkin();
        }
        else if (_bodyPartId == "Pants" && _playerStatsSO.currentPantsSo == _bodyPartSO)
        {
            _playerStatsSO.currentPantsSo = null;
            _customizationManager.ResetPantsSkin();
        }
        else if (_bodyPartId == "Boots" && _playerStatsSO.currentBootsSo == _bodyPartSO)
        {
            _playerStatsSO.currentBootsSo = null;
            _customizationManager.ResetBootsSkin();
        }
    }
    #endregion
    #region PublicMethods
    public void CheckPurchase()
    {
        if (_buyButton)
        {
            if (_bodyPartSO.isPurchased)
            {
                _lockedStatus.SetActive(true);
                _unlockedStatus.SetActive(false);
            }
            else
            {
                _unlockedStatus.SetActive(true);
                _lockedStatus.SetActive(false);
            }
        }
        else
        {
            if (_bodyPartSO.isPurchased)
            {
                _lockedStatus.SetActive(false);
                _unlockedStatus.SetActive(true);
            }
            else
            {
                _unlockedStatus.SetActive(false);
                _lockedStatus.SetActive(true);
            }
        }
    }

    public void BuyButton()
    {
        if (!_bodyPartSO.isPurchased && _playerStatsSO.coins >= _bodyPartSO.price)
        {
            _bodyPartSO.isPurchased = true;
            CheckPurchase();
            CheckId();
            _playerStatsSO.RemoveCoins(_bodyPartSO.price);
            _infoUi.UpdateCoinsText();
            _shopkeeper.PlayThankYouSound();
        }
        else if (!_bodyPartSO.isPurchased && _playerStatsSO.coins < _bodyPartSO.price)
        {
            _shopkeeper.PlayNotEnoughCashSound();
        }
    }

    public void SellButton()
    {
        if (_bodyPartSO.isPurchased)
        {
            _bodyPartSO.isPurchased = false;
            CheckPurchase();
            CheckCurrentSkin();
            _playerStatsSO.AddCoins(_bodyPartSO.price);
            _infoUi.UpdateCoinsText();
            _shopkeeper.PlayThankYouSound();
        }
    }

    public void WearSkinButton()
    {
        if (_bodyPartSO.isPurchased)
        {
            CheckId();
        }
    }
    #endregion
}
