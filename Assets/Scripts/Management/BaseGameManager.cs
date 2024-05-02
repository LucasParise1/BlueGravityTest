using UnityEngine;
using Cinemachine;

public class BaseGameManager : MonoBehaviour
{
    #region Variables
    [Header("Scriptable Objects")]
    [SerializeField] private PlayerStatsScriptableObject _playerStatsSO;
    [SerializeField] private BodyPartScriptableObject[] _allBodyPartsSO;

    [Header("Cameras")]
    [SerializeField] private CinemachineVirtualCamera _gameplayCamera;
    [SerializeField] private CinemachineVirtualCamera _customizationCamera;

    [Header("Canvas")]
    [SerializeField] private GameObject _storeCanvas;
    #endregion
    #region Lifecycle
    private void Start()
    {
        _playerStatsSO.ResetCoins();
        ResetAllBodyParts();
    }
    #endregion
    #region PrivateMethods
    private void ActivateStoreCanvas() => _storeCanvas.SetActive(true);

    private void ResetAllBodyParts()
    {
        for (int i = 0; i < _allBodyPartsSO.Length; i++)
        {
            _allBodyPartsSO[i].isPurchased = false;
        }
    }
    #endregion
    #region PublicMethods
    public void PlayerOnStore()
    {
        _gameplayCamera.enabled = false;
        _customizationCamera.enabled = true;
        Invoke(nameof(ActivateStoreCanvas), 1);
    }
    #endregion
}
