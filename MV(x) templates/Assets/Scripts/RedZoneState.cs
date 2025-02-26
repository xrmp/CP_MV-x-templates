using UnityEngine;

public class RedZoneState : State
{
    private PlayerCombat playerCombat;

    public RedZoneState(PlayerCombat combat)
    {
        playerCombat = combat;
    }

    public override void Enter()
    {
        Debug.Log("Entered Red Zone State");
        playerCombat.ToggleRedZone(true);
    }

    public override void Exit()
    {
        Debug.Log("Exited Red Zone State");
        playerCombat.ToggleRedZone(false);
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerCombat.ToggleRedZone(!playerCombat.IsRedZoneActive());
        }
    }
}