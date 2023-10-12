using UnityEngine;
using UnityEngine.Events;

public class CheckpointParent : MonoBehaviour
{
    [System.Serializable]
    public class CheckpointEnteredEvent : UnityEvent<GameObject> { }

    public CheckpointEnteredEvent onCheckpointEntered;
}
