using UnityEngine;

/// <summary>
/// Move strategy implementation for moving by mouse position.
/// </summary>
public class MoveByMouse : IMoveStrategy
{
    /// <summary>
    /// Applies move by mouse strategy on the vector.
    /// </summary>
    /// <param name="position">Current position.</param>
    /// <param name="speed">Speed to move. </param>
    /// <returns></returns>
    public Vector2 Move(Vector3 position, float speed)
    {
        // Return mouse position.
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
