using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMoveBackward : SubSteeringCommand
{
    public SubMoveBackward(Submarine sub) : base(sub)
    {

    }

    public override void Execute()
    {
        sub.SubMoveBackward();
    }
}
