using UnityEngine;

public class Player : MonoBehaviour
{
    // Move strategy types.
    private enum MoveStrategyType{
        ByMouse,
        ByKeyboard
    }

    // Move speed for move strategy.
    [SerializeField] private float _moveSpeed = 1f;

    // Current move strategy type.
    [SerializeField] private MoveStrategyType _moveStrategyType = MoveStrategyType.ByMouse;

    // Current move strategy.
    private IMoveStrategy _moveStrategy = null;

    /// <summary>
    /// Initializes a new instance.
    /// </summary>
    private void Start()
    {
        // Update move strategy type.
        _moveStrategy = GetCurrentMoveStrategy();
    }

    /// <summary>
    /// Return the current move strategy as object.
    /// </summary>
    private IMoveStrategy GetCurrentMoveStrategy()
    {
        return _moveStrategyType switch
        {
            MoveStrategyType.ByMouse => new MoveByMouse(),
            MoveStrategyType.ByKeyboard => new MoveByKeyboard(),
            _ => throw new System.NotImplementedException(),
        };
    }

    /// <summary>
    /// Movement update.
    /// </summary>
    private void Update()
    {
        // Movement from move strategy.
        transform.position = _moveStrategy.Move(transform.position, _moveSpeed);
    }
}
