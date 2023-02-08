using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]

public class PlayerShooter : MonoBehaviour
{
    private int shoot = 0;

    public void OnShoot(InputAction.CallbackContext context)
    {
        shoot++;
        Debug.Log($"shoot - {shoot}");
    }
}
