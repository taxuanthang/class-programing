using UnityEngine;

public class State : ScriptableObject
{
    public virtual void Enter(EnemyAIManager enemy) { }
    public virtual void Execute(EnemyAIManager enemy) { }
    public virtual void Exit(EnemyAIManager enemy) { }
}
