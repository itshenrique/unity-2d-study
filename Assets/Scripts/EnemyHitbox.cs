using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : Collidable
{
    // Damage
    public int damage;
    public float pushForce;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            // Create a new damage object, before sending it to the Player
            Damage dmg = new Damage
            {
                damageAmount = damage,
                origin = transform.position,
                pushForce = pushForce,
            };

            coll.SendMessage("ReceiveDamage", dmg);
        }
    }
}
