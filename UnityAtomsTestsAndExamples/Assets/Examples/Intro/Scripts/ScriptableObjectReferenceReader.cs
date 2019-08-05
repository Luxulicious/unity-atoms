using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Examples.Intro.Scripts
{
    public abstract class ScriptableObjectReferenceReader<T, V, E1, E2, GA1, GA2, UER1, UER2> :
        ScriptableObjectReference<T, V, E1, E2>
        where E1 : GameEvent<T>
        where E2 : GameEvent<T, T>
        where V : ScriptableObjectVariable<T, E1, E2>
        where GA1 : GameAction<T>
        where GA2 : GameAction<T, T>
        where UER1 : UnityEvent<T>
        where UER2 : UnityEvent<T, T>
    {

        [SerializeField] private ScriptableObjectReference<T, V, E1, E2> _reference;
        [SerializeField] private GameEventListener<T, GA1, E1, UER1> _changedListener;
        [SerializeField] private GameEventListener<T, T, GA2, E2, UER2> _changedWithHistoryListener;
        }
}
