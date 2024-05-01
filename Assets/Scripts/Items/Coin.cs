using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _myValue;
    [SerializeField] private PlayerStatsScriptableObject _playerStatsSO;
    [SerializeField] private Animator _animatedCoin;

    private bool _colided;
    private AudioSource _source;
    private PlayerInfoUi _infoUI;

    private void Start()
    {
        _infoUI = FindObjectOfType<PlayerInfoUi>();
        _source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !_colided)
        {
            _colided = true;
            _source.Play();
            _animatedCoin.SetTrigger("PickUp");
            _playerStatsSO.AddCoins(_myValue);
            _infoUI.UpdateCoinsText();
            Destroy(gameObject, 1);
        }
    }
}
