using UnityEngine;

public class Shopkeeper : MonoBehaviour
{
    private StandardPlayer _player;
    private bool _playerOn;

    private void Start() => _player = FindObjectOfType<StandardPlayer>();

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && _playerOn)
        {
            _playerOn = false;
            _player.StandByMode();
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
}
