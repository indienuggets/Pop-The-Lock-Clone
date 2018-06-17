using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public GameEvent[] Events;
    public UnityEvent Response;

    void OnEnable()
    {
        foreach (GameEvent ev in Events) { ev.Register(this); }
    }
    void OnDisable()
    {
        foreach (GameEvent ev in Events) { ev.DeRegister(this); }
    }

    public void OnEventRaised() { Response.Invoke(); }
}
