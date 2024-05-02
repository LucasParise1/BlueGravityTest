using UnityEngine;

public class Wardrobe : MonoBehaviour
{
    #region Variables
    [SerializeField] private Animator _animatedWardrobe;

    [Header("Audio")]
    [SerializeField] private AudioClip _openSound;
    [SerializeField] private AudioClip _closeSound;

    private StandardPlayer _player;
    private BaseGameManager _gameManager;
    private AudioSource _source;
    private OnClickInvoke _clickScript;
    private bool _playerOn;
    #endregion
    #region Lifecycle
    private void Start()
    {
        _source = GetComponent<AudioSource>();
        _player = FindObjectOfType<StandardPlayer>();
        _gameManager = FindObjectOfType<BaseGameManager>();
        _clickScript = GetComponent<OnClickInvoke>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && _playerOn)
        {
            _playerOn = false;
            _animatedWardrobe.SetBool("Open", true);
            _clickScript.OnClickInvokeButton();
            _player.StandByMode();
            _gameManager.PlayerOnWardrobe();
            PlayOpenSound();
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
    private void PlayOpenSound()
    {
        _source.clip = _openSound;
        _source.Play();
    }

    public void PlayCloseSound()
    {
        _animatedWardrobe.SetBool("Open", false);
        _source.clip = _closeSound;
        _source.Play();
    }
    #endregion
}
