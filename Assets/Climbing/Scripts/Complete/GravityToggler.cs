using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Since the vertical gravity in the moving provider accumulates even when it's not in use, 
/// we need to disable the gravity when climbing so the player doesn't snap to the ground.
/// </summary>
public class GravityToggler : MonoBehaviour
{
    private ClimbingProvider climbingProvider;
    private ContinuousMoveProviderBase moveProvider;

    private void Awake()
    {
        climbingProvider = GetComponentInParent<ClimbingProvider>();
        moveProvider = GetComponentInParent<ContinuousMoveProviderBase>();
    }

    private void OnEnable()
    {
        climbingProvider.beginLocomotion += DisableGravity;
        climbingProvider.endLocomotion += EnableGravity;
    }

    private void OnDisable()
    {
        climbingProvider.beginLocomotion -= DisableGravity;
        climbingProvider.endLocomotion -= EnableGravity;
    }

    private void EnableGravity(LocomotionSystem _) => ToggleGravity(true);

    private void DisableGravity(LocomotionSystem _) => ToggleGravity(false);

    private void ToggleGravity(bool value)
    {
        moveProvider.useGravity = value;
    }
}
