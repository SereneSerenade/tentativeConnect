using System;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.InputSystem;
using StarterAssets;

public class ClientPlayerMove : NetworkBehaviour
{
    [SerializedField] private PlayerInput m PlayerInput;
    [SerializedField] private StarterAssetsInputs m StarterAssetsInputs;
    [SerializedField] private ThirdPersonController m ThirdPersonController;

    private void Awake()
    {
        m_StarterAssetsInputs.enabled = false;
        m_PlayerInput.enabled = false;
        m_ThirdPersonController.enabled = false;
    }

    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();

        if (IsOwner)
        {
            m_StarterAssetsInputs.enabled = true;
            m_PlayerInput.enabled = true;
            m_ThirdPersonController.enabled = true;
        }
    }


}
