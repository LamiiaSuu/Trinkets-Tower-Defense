using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;
    private int pathIndex = 0;
    private float tempDistance;

    // Start is called before the first frame update
    void Start()
    {
        target = LevelManager.main.path[pathIndex];
        tempDistance = Vector2.Distance(target.position, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {

        if(Vector2.Distance(target.position, transform.position) > tempDistance){
            pathIndex++;
            

            if(pathIndex >= LevelManager.main.path.Length){
                Destroy(gameObject);
                return;
            }else{
                target = LevelManager.main.path[pathIndex];
            }
        }

        Vector2 direction = (target.position - transform.position).normalized;

        tempDistance = Vector2.Distance(target.position, transform.position);
        rb.velocity = direction*moveSpeed;
    }
}
