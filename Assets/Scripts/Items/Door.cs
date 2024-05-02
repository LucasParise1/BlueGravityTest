using UnityEngine;
using Cinemachine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform _nextPlayerPos;
    [SerializeField] private Transform _nextCameraTarget;
    [SerializeField] private CinemachineVirtualCamera _gameplayCam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.position = _nextPlayerPos.position;
            _gameplayCam.Follow = _nextCameraTarget;
        }
    }
}
