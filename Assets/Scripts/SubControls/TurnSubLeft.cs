using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSubLeft : SubSteeringCommand
{
    public TurnSubLeft(Submarine sub) : base(sub)
    {
    }

    public override void Execute()
    {
        sub.TurnSubLeft();
    }
}
