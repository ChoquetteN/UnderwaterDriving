using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMoveDown : SubSteeringCommand
{
    public SubMoveDown(Submarine sub) : base(sub)
    {
    }

    public override void Execute()
    {
        sub.SubMoveDown();
    }
}
