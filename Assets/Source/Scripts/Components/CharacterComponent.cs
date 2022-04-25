using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class CharacterComponent : MonoBehaviour
{
    [SerializeField] private float _speed;

    [SerializeField] private int _attackRange;
    [SerializeField] private int _damage;
    [SerializeField] private int _health;

    [SerializeField] private bool _isPlayer;

    private NavMeshAgent _navMeshAgent;
    private Transform _target;

    private bool _isAttacking;

    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.speed = _speed;

        this.enabled = false; // To prevent the "update" from working before the game starts
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, _target.position);

        if (distance <= _attackRange && _isAttacking == false)
        {
            _navMeshAgent.isStopped = true;
            _isAttacking = true;

            StartCoroutine(DealDamage());
        }

        else
        {
            _navMeshAgent.SetDestination(_target.position);
        }
    }

    public void TargetSet(Transform target)
    {
        _target = target;
        _isAttacking = false;
        _navMeshAgent.isStopped = false;
        _navMeshAgent.SetDestination(_target.position);
    }


    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            GameEvents.RemoveCharacter_E?.Invoke(gameObject, _isPlayer);
            gameObject.SetActive(false);
        }
    }

    IEnumerator DealDamage()
    {
        while (_target.gameObject.activeInHierarchy)
        {
            yield return new WaitForSeconds(1f);
            _target.GetComponent<CharacterComponent>().TakeDamage(_damage);
        }

        _isAttacking = false;
    }
}
