using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISelecatable : IHealthHolder
{
    Transform PivotPoint { get; }
    Sprite Icon { get; }
}

