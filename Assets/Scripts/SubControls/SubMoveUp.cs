using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMoveUp : SubSteeringCommand
{
    public SubMoveUp(Submarine sub) : base(sub)
    {
    }

    public override void Execute()
    {
        sub.SubMoveUp();
    }
}
