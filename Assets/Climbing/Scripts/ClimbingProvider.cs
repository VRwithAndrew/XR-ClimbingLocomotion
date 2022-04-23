using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// We average the velocity of the controllers and move the origin via a Character Controller or transform.
/// </summary>
public class ClimbingProvider : LocomotionProvider
{
    protected override void Awake()
    {
        base.Awake();
    }

    private void FindCharacterController()
    {

    }

    public void AddProvider(VelocityContainer provider)
    {

    }

    public void RemoveProvider(VelocityContainer provider)
    {

    }

    private void Update()
    {

    }

    private void TryBeginClimb()
    {

    }

    private void TryEndClimb()
    {

    }

    private bool CanClimb()
    {
        return false;
    }

    private void ApplyVelocity()
    {

    }

    private Vector3 CollectControllerVelocity()
    {
        return Vector3.zero;
    }
}
