using UnityEngine;

/// <summary>
/// Move strategy interface for inerhitance.
/// </summary>
interface IMoveStrategy
{
    /// <summary>
    /// Applies move strategy on the vector.
    /// </summary>
    /// <param name="position">Current position.</param>
    /// <param name="speed">Speed to move. </param>
    /// <returns></returns>
    Vector2 Move(Vector3 position, float speed);
}