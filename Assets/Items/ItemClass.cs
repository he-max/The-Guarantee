using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class ItemClass : ScriptableObject
{
    public int id {get; set;}
    public int weight {get; set;}

    public abstract void Use();
}
