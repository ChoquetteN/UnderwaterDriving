using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoInput : SubSteeringCommand
{
    public NoInput(Submarine Submarine) : base(Submarine)
    {
    }

    public override void Execute()
    {
        sub.noInput();
    }
}
