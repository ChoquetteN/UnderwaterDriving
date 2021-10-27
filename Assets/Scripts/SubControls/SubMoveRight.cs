using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMoveRight : SubSteeringCommand
{
    public SubMoveRight(Submarine sub) : base(sub)
    {

    }

    public override void Execute()
    {
        sub.SubMoveRight();
    }
}
