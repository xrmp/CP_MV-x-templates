using UnityEngine;

public class FinalState : State
{
    private PlayerCombat playerCombat;

    public FinalState(PlayerCombat combat)
    {
        playerCombat = combat;
    }

    public override void Enter()
    {
        Debug.Log("Entered Final State");
        playerCombat.SetColor(Color.green);
        playerCombat.SetTransparency(1f);
        playerCombat.DisableCombat();
    }

    public override void Exit()
    {
        Debug.Log("Exited Final State");
    }

    public override void Update()
    {

    }
}