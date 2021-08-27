using System.Collections;
using UnityEngine;

public class InvincibilityPowerUp : PowerUpBase
{
    Player _player;
    Color materialColor;

    protected override void PowerUp(Player player)
    {
        _player = player;

        materialColor = player.bodyMaterial.color;
        player.bodyMaterial.color = Color.grey;
        player.isInvincible = true;
    }

    protected override void PowerDown()
    {
        _player.bodyMaterial.color = materialColor;
        _player.isInvincible = false;
    }
}
