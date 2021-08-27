using UnityEngine;

public class Treasure : CollectibleBase
{
    [SerializeField] int _amount = 1;

    protected override void Collect(Player player)
    {
        player.IncreaseTreasure(_amount);
    }
}
