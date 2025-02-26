using UnityEngine;

public class ShootingState : State
{
    private PlayerCombat playerCombat;

    public ShootingState(PlayerCombat combat)
    {
        playerCombat = combat;
    }

    public override void Enter()
    {
        Debug.Log("Entered Shooting State");
    }

    public override void Exit()
    {
        Debug.Log("Exited Shooting State");
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerCombat.Shoot();
        }
    }
}