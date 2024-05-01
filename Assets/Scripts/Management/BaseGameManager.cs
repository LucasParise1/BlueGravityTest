using UnityEngine;

public class BaseGameManager : MonoBehaviour
{
    [SerializeField] private PlayerStatsScriptableObject _playerStatsSO;

    private void Start() => _playerStatsSO.ResetCoins();
}
