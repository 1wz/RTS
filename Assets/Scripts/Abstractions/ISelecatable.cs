using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISelecatable : IHealthHolder, IIconHolder
{
    Transform PivotPoint { get; }
}

