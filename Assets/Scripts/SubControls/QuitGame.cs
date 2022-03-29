using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : iCommand
{
    public void Execute()
    {
        Application.Quit();
    }
}
