using UnityEngine;


/// <summary>
/// Vector 관련 익스텐더
/// </summary>
public static class VectorExtend
{
    public static Vector2 Vector3ToXZ(this Vector3 p)
    {
        return new Vector2(p.x, p.z);
    }
    public static Vector2 Vector3ToYZ(this Vector3 p)
    {
        return new Vector2(p.y, p.z);
    }
    public static Vector2 Vector3ToZY(this Vector3 p)
    {
        return new Vector2(p.z, p.y);
    }
    public static Vector2 Vector3ToXY(this Vector3 p)
    {
        return new Vector2(p.x, p.y);
    }
    public static Vector2 Vector3ToYX(this Vector3 p)
    {
        return new Vector2(p.y, p.x);
    }
    public static Vector3 Vector2ToXYZ(this Vector3 p, float y = 0)
    {
        return new Vector3(p.x, y, p.z);
    }
    public static float[] ToFloat3Array(this Vector3 p)
    {
        return new float[] { p.x, p.y, p.z };
    }
    public static Vector3 ToVector3(this float[] p)
    {
        if (p.Length == 3)
        {
            return new Vector3(p[0], p[1], p[2]);
        }
        else
            return Vector3.zero;
    }

}