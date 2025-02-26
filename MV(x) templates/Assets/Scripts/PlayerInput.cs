using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private KeyCode attackKey = KeyCode.Mouse0;
    private bool isInputEnabled = true;

    public void EnableInput(bool isEnabled)
    {
        isInputEnabled = isEnabled;
    }

    public Vector2 GetMovementInput()
    {
        if (!isInputEnabled) return Vector2.zero;
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    public bool GetAttackInput()
    {
        if (!isInputEnabled) return false;
        return Input.GetKeyDown(attackKey);
    }
}