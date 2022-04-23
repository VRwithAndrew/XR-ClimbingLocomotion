using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Responsible for getting the velocity container from the controller to the climbing provider so it can be processed.
/// </summary>
public class ClimbAnchor : XRBaseInteractable
{
    protected override void Awake()
    {
        base.Awake();
    }

    private void FindClimbingProvider()
    {

    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
    }

    private void TryAdd(IXRSelectInteractor interactor)
    {

    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
    }

    private void TryRemove(IXRSelectInteractor interactor)
    {

    }

    public override bool IsHoverableBy(IXRHoverInteractor interactor)
    {
        return base.IsHoverableBy(interactor);
    }

    public override bool IsSelectableBy(IXRSelectInteractor interactor)
    {
        return base.IsSelectableBy(interactor);
    }
}
