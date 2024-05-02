using UnityEngine;
using UnityEngine.UI;

public class OnClickInvoke : MonoBehaviour
{
    [SerializeField] private Button _buttonToCallClick;

    public void OnClickInvokeButton() => _buttonToCallClick.onClick.Invoke();
}
