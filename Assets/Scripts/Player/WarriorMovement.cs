using UnityEngine;

public class WarriorMovement : MonoBehaviour
{
    [Header("Script")]
    [SerializeField] private PlayerInputHandler _inputHandler;

    [SerializeField] private Transform _transform;

    [SerializeField] private Animator _animator;

    [Header("Movement")]
    private float m_MoveSpeed = 10.0f;

    bool isAttacking = false;

    void Start()
    {

    }

    void Update()
    {
        if (isAttacking)
        {
            return;
        }
        Move();
        if (_inputHandler.Attack && !isAttacking)
        {
            StartCoroutine(Attack());
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

    private System.Collections.IEnumerator Attack()
    {
        isAttacking = true;
        _animator.SetBool("isAttacking", true);

        AnimatorClipInfo[] clipInfo = _animator.GetCurrentAnimatorClipInfo(0);
        float attackDuration = clipInfo[0].clip.length;
        yield return new WaitForSeconds(attackDuration);

        _animator.SetBool("isAttacking", false);
        isAttacking = false;
    }
}
