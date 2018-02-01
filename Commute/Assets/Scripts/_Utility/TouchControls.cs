using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ScreenSide {
    LeftSide,
    MiddleSide,
    RightSide
}

/// <summary>
/// Helper methods to get information about touch input
/// </summary>
public static class TouchControls
{

    readonly static int LEFT_SIDE_RIGHT_EDGE = Screen.width / 3;
    readonly static int RIGHT_SIDE_LEFT_EDGE = Screen.width / 3 * 2;

    #region Public Methods

    /// <summary>
    /// Given the screenside, it determines if the touch given is on that side of the screen.
    /// </summary>
    /// <returns><c>true</c>, if given side was touched, <c>false</c> otherwise.</returns>
    /// <param name="side">Side of screen</param>
    /// <param name="touch">Touch object</param>
    public static bool TouchOnSide(ScreenSide side, Touch touch)
    {
        switch (side)
        {
            case ScreenSide.LeftSide:
                return TouchOnLeftSide(touch);
            case ScreenSide.MiddleSide:
                return TouchOnMiddleSide(touch);
            case ScreenSide.RightSide:
                return TouchOnRightSide(touch);
            default:
                return false;
        }
    }

    /// <summary>
    /// Given the screenside, it determines if there is a touch in any state on that side of the screen.
    /// </summary>
    /// <returns><c>true</c>, if on side was held, <c>false</c> otherwise.</returns>
    /// <param name="side">Side.</param>
    /// <param name="touch">Touch.</param>
    public static bool HoldOnSide(ScreenSide side, Touch touch) {

        switch (side)
        {
            case ScreenSide.LeftSide:
                return HoldOnLeftSide(touch);
            case ScreenSide.MiddleSide:
                return HoldOnMiddleSide(touch);
            case ScreenSide.RightSide:
                return HoldOnRightSide(touch);
            default:
                return false;
        }
    }

    /// <summary>
    /// Determines if there was a single touch in the last frame on the left side of the screen.
    /// </summary>
    /// <returns><c>true</c>, if on left side was touched, <c>false</c> otherwise.</returns>
    /// <param name="touch">Touch object</param>
    public static bool TouchOnLeftSide(Touch touch)
    {
        return HoldOnLeftSide(touch)
            && touch.phase == TouchPhase.Began;
    }

    /// <summary>
    /// Determines if there was a single touch in the last frame in the middle of the screen.
    /// </summary>
    /// <returns><c>true</c>, if on middle side was touched, <c>false</c> otherwise.</returns>
    /// <param name="touch">Touch object</param>
    public static bool TouchOnMiddleSide(Touch touch)
    {
        return HoldOnMiddleSide(touch)
            && touch.phase == TouchPhase.Began;
    }

    /// <summary>
    /// Determines if there was a single touch in the last frame on the right side of the screen.
    /// </summary>
    /// <returns><c>true</c>, if on right side was touched, <c>false</c> otherwise.</returns>
    /// <param name="touch">Touch object</param>
    public static bool TouchOnRightSide(Touch touch)
    {
        return HoldOnRightSide(touch)
            && touch.phase == TouchPhase.Began;
    }

    /// <summary>
    /// Determines if there is a touch in any state on the left side of the screen.
    /// </summary>
    /// <returns><c>true</c>, if on left side was held, <c>false</c> otherwise.</returns>
    /// <param name="touch">Touch.</param>
    public static bool HoldOnLeftSide(Touch touch)
    {
        return touch.position.x <= LEFT_SIDE_RIGHT_EDGE;
    }

    /// <summary>
    /// Determines if there is a touch in any state in the middle of the screen.
    /// </summary>
    /// <returns><c>true</c>, if on middle side was held, <c>false</c> otherwise.</returns>
    /// <param name="touch">Touch.</param>
    public static bool HoldOnMiddleSide(Touch touch)
    {
        return touch.position.x > LEFT_SIDE_RIGHT_EDGE
                    && touch.position.x < RIGHT_SIDE_LEFT_EDGE;
    }

    /// <summary>
    /// Determines if there is a touch in any state on the right side of the screen.
    /// </summary>
    /// <returns><c>true</c>, if on right side was held, <c>false</c> otherwise.</returns>
    /// <param name="touch">Touch.</param>
    public static bool HoldOnRightSide(Touch touch)
    {
        return touch.position.x >= RIGHT_SIDE_LEFT_EDGE;
    }

    /// <summary>
    /// Gets the Y Position on screen.
    /// </summary>
    /// <returns>The Y Position on screen.</returns>
    /// <param name="touch">Touch.</param>
    public static float GetYPositionOnScreen(Touch touch) {
        return touch.position.y;
    }

    /// <summary>
    /// Gets the Y position on screen between a specified range (e.g. between 0 and 1, where the bottom is 0, and the top is 1).
    /// </summary>
    /// <returns>The Y Position on screen between range.</returns>
    /// <param name="touch">Touch.</param>
    /// <param name="min">Minimum.</param>
    /// <param name="max">Max.</param>
    public static float GetYPositionOnScreenBetweenRange(Touch touch, float min, float max) {
        if (min > max) {
            var temp = min;
            min = max;
            max = temp;
        }

        return (max - min) * touch.position.y / Screen.height + min;
    }

    #endregion

    #region Private Methods



    #endregion

}
