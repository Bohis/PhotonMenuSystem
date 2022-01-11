// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""a59c8f41-3222-4d16-9f1c-12a5d6238409"",
            ""actions"": [
                {
                    ""name"": ""ChangeActiveMenu"",
                    ""type"": ""Button"",
                    ""id"": ""855ab2b5-136d-4f6e-af48-43968776e56b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CnahgeActiveScoreList"",
                    ""type"": ""Button"",
                    ""id"": ""2f83b38e-5a13-4881-aedd-3a0de80c14ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""74bb53cb-2015-4851-b1f5-5b096388546b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeActiveMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""244abe29-7c34-4bf0-9444-608e75633bf7"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CnahgeActiveScoreList"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Debug"",
            ""id"": ""0a89c317-8214-4787-b523-a879766d53bb"",
            ""actions"": [
                {
                    ""name"": ""Console"",
                    ""type"": ""Button"",
                    ""id"": ""d635eb6f-bbf4-415f-b29f-b8db4e7edb57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dc465eee-569b-45fc-b96e-30a6ac95aaff"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Console"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_ChangeActiveMenu = m_Menu.FindAction("ChangeActiveMenu", throwIfNotFound: true);
        m_Menu_CnahgeActiveScoreList = m_Menu.FindAction("CnahgeActiveScoreList", throwIfNotFound: true);
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_Console = m_Debug.FindAction("Console", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_ChangeActiveMenu;
    private readonly InputAction m_Menu_CnahgeActiveScoreList;
    public struct MenuActions
    {
        private @Controls m_Wrapper;
        public MenuActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeActiveMenu => m_Wrapper.m_Menu_ChangeActiveMenu;
        public InputAction @CnahgeActiveScoreList => m_Wrapper.m_Menu_CnahgeActiveScoreList;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @ChangeActiveMenu.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnChangeActiveMenu;
                @ChangeActiveMenu.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnChangeActiveMenu;
                @ChangeActiveMenu.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnChangeActiveMenu;
                @CnahgeActiveScoreList.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnCnahgeActiveScoreList;
                @CnahgeActiveScoreList.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnCnahgeActiveScoreList;
                @CnahgeActiveScoreList.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnCnahgeActiveScoreList;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChangeActiveMenu.started += instance.OnChangeActiveMenu;
                @ChangeActiveMenu.performed += instance.OnChangeActiveMenu;
                @ChangeActiveMenu.canceled += instance.OnChangeActiveMenu;
                @CnahgeActiveScoreList.started += instance.OnCnahgeActiveScoreList;
                @CnahgeActiveScoreList.performed += instance.OnCnahgeActiveScoreList;
                @CnahgeActiveScoreList.canceled += instance.OnCnahgeActiveScoreList;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_Console;
    public struct DebugActions
    {
        private @Controls m_Wrapper;
        public DebugActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Console => m_Wrapper.m_Debug_Console;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @Console.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnConsole;
                @Console.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnConsole;
                @Console.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnConsole;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Console.started += instance.OnConsole;
                @Console.performed += instance.OnConsole;
                @Console.canceled += instance.OnConsole;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);
    public interface IMenuActions
    {
        void OnChangeActiveMenu(InputAction.CallbackContext context);
        void OnCnahgeActiveScoreList(InputAction.CallbackContext context);
    }
    public interface IDebugActions
    {
        void OnConsole(InputAction.CallbackContext context);
    }
}
