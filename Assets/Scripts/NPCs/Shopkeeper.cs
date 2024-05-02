using UnityEngine;

public class Shopkeeper : MonoBehaviour
{
    #region Variables
    [Header("Audio")]
    [SerializeField] private AudioClip _welcomeSound;
    [SerializeField] private AudioClip _thankYouSound;
    [SerializeField] private AudioClip _noCashSound;
    [SerializeField] private AudioClip _buySound;
    [SerializeField] private AudioClip _sellSound;
    [SerializeField] private AudioClip _comeBackSound;

    private StandardPlayer _player;
    private BaseGameManager _gameManager;
    private AudioSource _source;
    private bool _playerOn;
    #endregion
    #region Lifecycle
    private void Start()
    {
        _source = GetComponent<AudioSource>();
        _player = FindObjectOfType<StandardPlayer>();
        _gameManager = FindObjectOfType<BaseGameManager>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && _playerOn)
        {
            _playerOn = false;
            _player.StandByMode();
            _gameManager.PlayerOnStore();
            Invoke(nameof(PlayWelcomeSound), 0.5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !_playerOn)
        {
            _playerOn = true;
            _player.EnableInteractionIcon();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player" && _playerOn)
        {
            _playerOn = false;
            _player.DisableInteractionIcon();
        }
    }
    #endregion
    #region AudioMethods
    private void PlayWelcomeSound()
    {
        _source.clip = _welcomeSound;
        _source.Play();
    }

    public void PlayThankYouSound()
    {
        _source.clip = _thankYouSound;
        _source.Play();
    }

    public void PlayNotEnoughCashSound()
    {
        _source.clip = _noCashSound;
        _source.Play();
    }

    public void PlayBuySound()
    {
        _source.clip = _buySound;
        _source.Play();
    }

    public void PlaySellSound()
    {
        _source.clip = _sellSound;
        _source.Play();
    }

    public void PlayComeBackSound()
    {
        _source.clip = _comeBackSound;
        _source.Play();
    }
    #endregion
}
