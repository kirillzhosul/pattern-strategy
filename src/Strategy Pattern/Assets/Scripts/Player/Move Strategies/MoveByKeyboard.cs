using UnityEngine;

/// <summary>
/// Move strategy implementation for moving by keyboard axis.
/// </summary>
public class MoveByKeyboard : IMoveStrategy
{
    /// <summary>
    /// Applies move by keyboard strategy on the vector.
    /// </summary>
    /// <param name="position">Current position.</param>
    /// <param name="speed">Speed to move. </param>
    /// <returns></returns>
    public Vector2 Move(Vector3 position, float speed)
    {
        // Get move vector.
        Vector2 newPosition = Vector2.zero;
        newPosition.x = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        newPosition.y = speed * Input.GetAxis("Vertical") * Time.deltaTime;

        // Move position.
        return (Vector2)position + newPosition;
    }
}
