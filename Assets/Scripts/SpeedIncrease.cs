using UnityEngine;

public class SpeedIncrease : CollectibleBase
{
    [SerializeField] float _speedAmount = 5;

    protected override void Collect(Player player)
    {
        //pull motor controller from player
        TankController controller = player.GetComponent<TankController>();
        if(controller != null)
        {
            controller.MoveSpeed += _speedAmount;
        }
    }

    protected override void Movement(Rigidbody rb)
    {
        Quaternion turnOffset = Quaternion.Euler(MovementSpeed, MovementSpeed, MovementSpeed);
        rb.MoveRotation(rb.rotation * turnOffset);
    }
}
