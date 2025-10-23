using UnityEngine;

public class WarriorMovement : MonoBehaviour
{
    [Header("Script")]
    [SerializeField] private PlayerInputHandler _inputHandler;

    [SerializeField] private Transform _transform;

    [SerializeField] private Animator _animator;

    [Header("Movement")]
    private float m_MoveSpeed = 10.0f;

    void Start()
    {

    }

    void Update()
    {
        if (_inputHandler.Attack == false)
        {
            Debug.Log("pasattack");
            _animator.SetBool("isAttacking", false);
            Move();
        }
        else
        {
            Debug.Log("attack");
            _animator.SetBool("isAttacking", true);
            Attack();
        }
        
    }

    public void Move()
    {
        Vector2 move = _inputHandler.MoveInput;
        if (move.x < 0) { 
            _transform.localRotation = Quaternion.Euler(0, 180, 0);
            _animator.SetBool("isMoving", true);
        } 
        else if (move.x > 0 ) { 
            _transform.localRotation = Quaternion.Euler(0, 0, 0); 
            _animator.SetBool("isMoving", true); 
        } 
        else { 
            _animator.SetBool("isMoving", false); 
        }
            Vector3 moveDirection = new Vector3(move.x, 0f, 0f);
        _transform.position += moveDirection * (m_MoveSpeed * Time.deltaTime);
    }

    public void Attack()
    {
        _animator.SetTrigger("Attack");
    }
}
