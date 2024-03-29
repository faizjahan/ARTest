//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scenes/ARSampleActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ARSampleActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ARSampleActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ARSampleActions"",
    ""maps"": [
        {
            ""name"": ""ARSampleControls"",
            ""id"": ""761eca32-c6d5-4baa-9ef8-8a86f4db1c3c"",
            ""actions"": [
                {
                    ""name"": ""ScreenTouch"",
                    ""type"": ""Value"",
                    ""id"": ""495d032a-2210-4668-acf4-ca5f8ed623b1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0df2d8dd-335a-48aa-a4ad-8ec7efeb0a20"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScreenTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ARSampleControls
        m_ARSampleControls = asset.FindActionMap("ARSampleControls", throwIfNotFound: true);
        m_ARSampleControls_ScreenTouch = m_ARSampleControls.FindAction("ScreenTouch", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // ARSampleControls
    private readonly InputActionMap m_ARSampleControls;
    private IARSampleControlsActions m_ARSampleControlsActionsCallbackInterface;
    private readonly InputAction m_ARSampleControls_ScreenTouch;
    public struct ARSampleControlsActions
    {
        private @ARSampleActions m_Wrapper;
        public ARSampleControlsActions(@ARSampleActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @ScreenTouch => m_Wrapper.m_ARSampleControls_ScreenTouch;
        public InputActionMap Get() { return m_Wrapper.m_ARSampleControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ARSampleControlsActions set) { return set.Get(); }
        public void SetCallbacks(IARSampleControlsActions instance)
        {
            if (m_Wrapper.m_ARSampleControlsActionsCallbackInterface != null)
            {
                @ScreenTouch.started -= m_Wrapper.m_ARSampleControlsActionsCallbackInterface.OnScreenTouch;
                @ScreenTouch.performed -= m_Wrapper.m_ARSampleControlsActionsCallbackInterface.OnScreenTouch;
                @ScreenTouch.canceled -= m_Wrapper.m_ARSampleControlsActionsCallbackInterface.OnScreenTouch;
            }
            m_Wrapper.m_ARSampleControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ScreenTouch.started += instance.OnScreenTouch;
                @ScreenTouch.performed += instance.OnScreenTouch;
                @ScreenTouch.canceled += instance.OnScreenTouch;
            }
        }
    }
    public ARSampleControlsActions @ARSampleControls => new ARSampleControlsActions(this);
    public interface IARSampleControlsActions
    {
        void OnScreenTouch(InputAction.CallbackContext context);
    }
}
