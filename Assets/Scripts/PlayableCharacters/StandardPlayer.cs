using UnityEngine;

public class StandardPlayer : MonoBehaviour
{
    #region Variables
    [SerializeField] private Animator _animatedPlayer;
    [SerializeField] private GameObject _playerIcon;

    private Rigidbody2D _rb;
    private float _speedX;
    private float _speedY;

    public float speed;
    #endregion
    #region Lifecycle
    private void Start() => _rb = GetComponent<Rigidbody2D>();
    private void Update() => Move();
    #endregion
    #region PrivateMethods
    private void Move()
    {
        _speedX = Input.GetAxisRaw("Horizontal") * speed;
        _speedY = Input.GetAxisRaw("Vertical") * speed;
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
    #region PublicMethods
    public void EnableInteractionIcon() => _playerIcon.SetActive(true);
    public void DisableInteractionIcon() => _playerIcon.SetActive(false);

    public void StandByMode()
    {
        this.enabled = false;
        _rb.velocity = Vector2.zero;
        DisableInteractionIcon();
        _animatedPlayer.SetBool("Run", false);
        _animatedPlayer.transform.localScale = new Vector3(1, 1, 1);
    }
    #endregion
}
