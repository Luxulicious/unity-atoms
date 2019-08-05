using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityAtoms;

namespace Assets.Examples.Intro.Scripts
{
    public class IntReferenceReader : ScriptableObjectReferenceReader<
        int,
        IntVariable,
        IntEvent,
        IntIntEvent,
        GameAction<int>,
        GameAction<int, int>,
        UnityIntEvent,
        UnityIntIntEvent>
    {
    }
}
