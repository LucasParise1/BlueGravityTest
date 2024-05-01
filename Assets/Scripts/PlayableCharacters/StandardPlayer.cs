using UnityEngine;

public class StandardPlayer : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _speed;
    [SerializeField] private Animator _animatedPlayer;

    private Rigidbody2D _rb;
    private float _speedX;
    private float _speedY;
    #endregion
    #region Lifecycle
    private void Start() => _rb = GetComponent<Rigidbody2D>();
    private void Update() => Move();
    #endregion
    #region PrivateMethods
    private void Move()
    {
        _speedX = Input.GetAxisRaw("Horizontal") * _speed;
        _speedY = Input.GetAxisRaw("Vertical") * _speed;
        _rb.velocity = new Vector2(_speedX, _speedY);
        PlayWalkAnimation();
    }

    private void PlayWalkAnimation()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            _animatedPlayer.SetBool("Run", true);
            _animatedPlayer.transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            _animatedPlayer.SetBool("Run", true);
            _animatedPlayer.transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetAxisRaw("Vertical") < 0 || Input.GetAxisRaw("Vertical") > 0)
        {
            _animatedPlayer.SetBool("Run", true);
        }
        else
        {
            _animatedPlayer.SetBool("Run", false);
        }
    }
    #endregion
}
