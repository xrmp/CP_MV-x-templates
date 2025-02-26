using UnityEngine;

public class TransparentState : State
{
    private PlayerCombat playerCombat;

    public TransparentState(PlayerCombat combat)
    {
        playerCombat = combat;
    }

    public override void Enter()
    {
        Debug.Log("Entered Transparent State");
        playerCombat.SetTransparency(0.5f);
    }

    public override void Exit()
    {
        Debug.Log("Exited Transparent State");
        playerCombat.SetTransparency(1f);
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerCombat.ToggleTransparency();
        }
    }
}