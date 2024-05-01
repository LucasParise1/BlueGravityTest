using UnityEngine;
using TMPro;

public class PlayerInfoUi : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinsText;
    [SerializeField] private PlayerStatsScriptableObject _playerStatsSO;

    private void Start() => UpdateCoinsText();
    public void UpdateCoinsText() => _coinsText.text = "x " + _playerStatsSO.coins;
}
