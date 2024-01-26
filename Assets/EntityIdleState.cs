using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class EntityIdleState : EntityState
{

    public override void EnterState(Entity entity)
    {
        Debug.Log("medle");
    }

    public override void UpdateState(Entity entity)
    {
        entity.transform.localScale += new Vector3(0.01f, 0, 0);
    }

    public override void FixedUpdateState(Entity entity)
    {
        entity.rigidBody.velocity = new Vector2(entity.rigidBody.velocity.x, entity.rigidBody.velocity.y);
    }

    public override void OnCollisionEnter(Entity entity)
    {

    }

}
