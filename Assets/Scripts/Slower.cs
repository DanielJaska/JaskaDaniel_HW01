﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slower : Enemy
{
    [SerializeField] float _speedAmount = .01f;

    protected override void PlayerImpact(Player player)
    {
        //pull motor controller from player
        TankController controller = player.GetComponent<TankController>();
        if (controller != null)
        {
            controller.MoveSpeed -= _speedAmount;
            controller.MoveSpeed = Mathf.Clamp(.05f, 0, controller.MoveSpeed);
        }
    }
}