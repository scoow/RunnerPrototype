//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/Scripts/Controls.inputactions
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

namespace TopEngineTeam
{
    public partial class @Controls : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""35f9cec6-589d-4bb3-9ee4-2e55111dd66e"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fa218279-c3c3-4a52-ad6f-4860fe575cf0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AD"",
                    ""type"": ""Button"",
                    ""id"": ""1bc79bb9-f0d8-47e7-96ca-d091263ca564"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftRightArrow"",
                    ""type"": ""Button"",
                    ""id"": ""92022582-689b-4c51-95b8-e0c84981ce74"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e90e734e-588f-4796-8bc6-d5f5395ee3dd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""64612e85-6597-4fd3-b289-56870a89511a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""aaf5d16b-ac28-4115-bea8-cbad0409a2d5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5afeb8b6-d3c8-4edf-baca-d67ff3920f01"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9a0e310d-285a-410d-90f0-3a043e6ea204"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightArrow"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""26fb0357-54ce-4c83-84ce-d839c2fd424c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightArrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""952fb039-1858-4a63-87da-fd0b13df0fac"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightArrow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerControls
            m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
            m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
            m_PlayerControls_AD = m_PlayerControls.FindAction("AD", throwIfNotFound: true);
            m_PlayerControls_LeftRightArrow = m_PlayerControls.FindAction("LeftRightArrow", throwIfNotFound: true);
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

        // PlayerControls
        private readonly InputActionMap m_PlayerControls;
        private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
        private readonly InputAction m_PlayerControls_Jump;
        private readonly InputAction m_PlayerControls_AD;
        private readonly InputAction m_PlayerControls_LeftRightArrow;
        public struct PlayerControlsActions
        {
            private @Controls m_Wrapper;
            public PlayerControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
            public InputAction @AD => m_Wrapper.m_PlayerControls_AD;
            public InputAction @LeftRightArrow => m_Wrapper.m_PlayerControls_LeftRightArrow;
            public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerControlsActions instance)
            {
                if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
                {
                    @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                    @AD.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAD;
                    @AD.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAD;
                    @AD.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAD;
                    @LeftRightArrow.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeftRightArrow;
                    @LeftRightArrow.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeftRightArrow;
                    @LeftRightArrow.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLeftRightArrow;
                }
                m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @AD.started += instance.OnAD;
                    @AD.performed += instance.OnAD;
                    @AD.canceled += instance.OnAD;
                    @LeftRightArrow.started += instance.OnLeftRightArrow;
                    @LeftRightArrow.performed += instance.OnLeftRightArrow;
                    @LeftRightArrow.canceled += instance.OnLeftRightArrow;
                }
            }
        }
        public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
        public interface IPlayerControlsActions
        {
            void OnJump(InputAction.CallbackContext context);
            void OnAD(InputAction.CallbackContext context);
            void OnLeftRightArrow(InputAction.CallbackContext context);
        }
    }
}
