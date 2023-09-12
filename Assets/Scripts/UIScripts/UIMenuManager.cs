using deVoid.UIFramework;
using deVoid.Utils;
using UnityEngine;

public sealed class UIMenuManager : MonoBehaviour
{
    [SerializeField] private UISettings _defaultUISetting = null;
    private UIFrame _uIFrameMenu;

    private void Awake()
    {
        _uIFrameMenu = _defaultUISetting.CreateUIInstance();
    }

}