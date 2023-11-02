using System.Numerics;
using System.Runtime.CompilerServices;

namespace Oblikovati.Contracts;

public static class QuaternionExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion From(Vector3 u, Vector3 v)
    {
        var n = Vector3.Cross(u,v);

        var q = new Quaternion();
        
        double s, tr = 1 + u.X + v.Y + n.Z;
        if(tr > 1e-4) {
            s = 2*Math.Sqrt(tr);
            q.W =(floating) s/4;
            q.X =(floating) ((v.Z - n.Y)/s);
            q.Y =(floating) ((n.X - u.Z)/s);
            q.Z =(floating) ((u.Y - v.X)/s);
        } else {
            if(u.X > v.Y && u.X > n.Z) {
                s = 2*Math.Sqrt(1 + u.X - v.Y - n.Z);
                q.W =(floating) ((v.Z - n.Y)/s);
                q.X =(floating) s/4;
                q.Y =(floating) ((u.Y + v.X)/s);
                q.Z =(floating) ((n.X + u.Z)/s);
            } else if(v.Y > n.Z) {
                s = 2*Math.Sqrt(1 - u.X + v.Y - n.Z);
                q.W =(floating) ((n.X - u.Z)/s);
                q.X =(floating) ((u.Y + v.X)/s);
                q.Y =(floating) s/4;
                q.Z =(floating) ((v.Z + n.Y)/s);
            } else {
                s = 2*Math.Sqrt(1 - u.X - v.Y + n.Z);
                q.W =(floating) ((u.Y - v.X)/s);
                q.X =(floating) ((n.X + u.Z)/s);
                q.Y =(floating) ((v.Z + n.Y)/s);
                q.Z =(floating) s/4;
            }
        }

        return q.WithMagnitude(1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion WithMagnitude(this Quaternion q, double s)
    {
        return q.ScaledBy(s/q.Magnitude());
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Magnitude(this Quaternion q)
    {
        return q.Length();;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 RotationU(this Quaternion q)
    {
        return new Vector3
        {
            X = q.W * q.W + q.X * q.X - q.Y * q.Y - q.Z * q.Z,
            Y = 2 * q.W * q.Z + 2 * q.X * q.Y,
            Z = 2 * q.X * q.Z - 2 * q.W * q.Y
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 RotationV(this Quaternion q)
    {
        return new Vector3
        {
            X = 2 * q.X * q.Y - 2 * q.W * q.Z,
            Y = q.W * q.W - q.X * q.X + q.Y * q.Y - q.Z * q.Z,
            Z = 2 * q.W * q.X + 2 * q.Y * q.Z
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 RotationN(this Quaternion q)
    {
        return new Vector3
        {
            X = 2 * q.W * q.Y + 2 * q.X * q.Z,
            Y = 2 * q.Y * q.Z - 2 * q.W * q.X,
            Z = q.W * q.W - q.X * q.X - q.Y * q.Y + q.Z * q.Z
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Rotate(this Quaternion q, Vector3 p)
    {
        return (q.RotationU().ScaledBy(p.X)).Plus(
                q.RotationV().ScaledBy(p.Y)).Plus(
                q.RotationN().ScaledBy(p.Z));
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion ScaledBy(this Quaternion q, double s)
    {
        return new Quaternion
        {
            W = q.W * (floating) s,
            X = q.X * (floating) s,
            Y = q.Y * (floating) s,
            Z = q.Z * (floating) s
        };
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion Times(this Quaternion q, Quaternion b)
    {
        var sa = q.W;
        var sb = b.W;
        var va = new Vector3( q.X, q.Y, q.Z );
        var vb = new Vector3( b.X, b.Y, b.Z );
        
        var vr = vb.ScaledBy(sa).Plus(va.ScaledBy(sb).Plus(Vector3.Cross(va,vb)));
        
        return new Quaternion
        {
            W = sa*sb - Vector3.Dot(va,vb),
            X = vr.X,
            Y = vr.Y,
            Z = vr.Z
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Quaternion Mirror(this Quaternion q)
    {
        Vector3 u = q.RotationU(), v = q.RotationV(); u = u.ScaledBy(-1); v = v.ScaledBy(-1);
        return From(u, v);
    }
}