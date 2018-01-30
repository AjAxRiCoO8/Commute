using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Helper methods to get information about touch input
/// </summary>
public static class TouchControls
{

    readonly static int LEFT_SIDE_RIGHT_EDGE = Screen.width / 3;
    readonly static int RIGHT_SIDE_LEFT_EDGE = Screen.width / 3 * 2;

    #region Public Methods

    /// <summary>
    /// Determines if there was a single touch in the last frame on the left side of the screen
    /// </summary>
    /// <returns><c>true</c>, if on left side was touched, <c>false</c> otherwise.</returns>
    /// <param name="touch">Touch object</param>
    public static bool TouchOnLeftSide(Touch touch)
    {
        return HitOnLeftSide(touch)
            && touch.phase == TouchPhase.Began;
    }

    /// <summary>
    /// Determines if there was a single touch in the last frame in the middle of the screen
    /// </summary>
    /// <returns><c>true</c>, if on middle side was touched, <c>false</c> otherwise.</returns>
    /// <param name="touch">Touch object</param>
    public static bool TouchOnMiddleSide(Touch touch)
    {
        return HitOnMiddleSide(touch)
            && touch.phase == TouchPhase.Began;
    }

    /// <summary>
    /// Determines if there was a single touch in the last frame on the right side of the screen
    /// </summary>
    /// <returns><c>true</c>, if on right side was touched, <c>false</c> otherwise.</returns>
    /// <param name="touch">Touch object</param>
    public static bool TouchOnRightSide(Touch touch)
    {
        return HitOnRightSide(touch)
            && touch.phase == TouchPhase.Began;
    }



    #endregion

    #region Private Methods

    private static bool HitOnLeftSide(Touch touch)
    {
        return touch.position.x <= LEFT_SIDE_RIGHT_EDGE;
    }

    private static bool HitOnMiddleSide(Touch touch)
    {
        return touch.position.x > LEFT_SIDE_RIGHT_EDGE
                    && touch.position.x < RIGHT_SIDE_LEFT_EDGE;
    }

    private static bool HitOnRightSide(Touch touch)
    {
        return touch.position.x >= RIGHT_SIDE_LEFT_EDGE;
    }

    #endregion

}
