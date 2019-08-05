using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    [Serializable]
    public class UnityIntEvent : UnityEvent<int> { }
    [Serializable]
    public class UnityIntIntEvent : UnityEvent<int, int> { }
}
