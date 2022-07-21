using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPosition : MonoBehaviour
{
    public enum AxisType
    {
        x,
        y,
        z
    }

    [SerializeField] AxisType lockedAxis; // This is the axis that will be locked

    [SerializeField] float lockValue; // This is the value to lock the axis on

    [SerializeField] Transform ObjectToLock; // This is the object who's axis will be locked

    private void Update()
    {
        if (lockedAxis == AxisType.x) 
            ObjectToLock.transform.position = new Vector3(
                lockValue,
                ObjectToLock.transform.position.y,
                ObjectToLock.transform.position.z
            );

        if (lockedAxis == AxisType.y)
            ObjectToLock.transform.position = new Vector3(
                 ObjectToLock.transform.position.x,
                 lockValue,
                ObjectToLock.transform.position.z
            );

        if (lockedAxis == AxisType.z)
            ObjectToLock.transform.position = new Vector3(
                 ObjectToLock.transform.position.x,
                ObjectToLock.transform.position.y,
                lockValue
            );
    }
}
