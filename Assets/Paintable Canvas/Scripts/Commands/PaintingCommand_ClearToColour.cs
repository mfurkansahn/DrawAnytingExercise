using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingCommand_ClearToColour : BasePaintingCommand
{
    Color ColourToClearTo;

    public PaintingCommand_ClearToColour(Color InColour, bool InIsUndoable = true):
        base(InIsUndoable)
    {
        ColourToClearTo = InColour;
    }
}
