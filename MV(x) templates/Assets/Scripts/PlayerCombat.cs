using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private SpriteRenderer redZoneSprite;
    [SerializeField] private SpriteRenderer playerSprite;

    public void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void ToggleRedZone(bool isActive)
    {
        redZoneSprite.enabled = isActive;
    }

    public bool IsRedZoneActive()
    {
        return redZoneSprite.enabled;
    }

    public void SetTransparency(float alpha)
    {
        Color color = playerSprite.color;
        color.a = alpha;
        playerSprite.color = color;
    }

    public void ToggleTransparency()
    {
        if (playerSprite.color.a == 1f)
        {
            SetTransparency(0.5f);
        }
        else
        {
            SetTransparency(1f);
        }
    }

    public void SetColor(Color color)
    {
        playerSprite.color = color;
    }

    public void DisableCombat()
    {
        ToggleRedZone(false);
        SetTransparency(1f);
    }
}