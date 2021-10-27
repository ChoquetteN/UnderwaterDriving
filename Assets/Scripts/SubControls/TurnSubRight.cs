using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSubRight : SubSteeringCommand
{
    public TurnSubRight(Submarine sub) : base(sub)
    {
    }

    public override void Execute()
    {
        sub.TurnSubRight();
    }
}
