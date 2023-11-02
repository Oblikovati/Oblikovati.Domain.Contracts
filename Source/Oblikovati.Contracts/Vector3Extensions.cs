using System.Numerics;
using System.Runtime.CompilerServices;

namespace Oblikovati.Contracts;

public static class Vector3Extensions
{
    //We want to save in jumps and stack allocation so using aggressive inlining as much as possible here
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 ClosestOrtho(this Vector3 v)
    {
        floating mx = MathF.Abs(v.X), my = MathF.Abs(v.Y), mz = MathF.Abs(v.Z);

        if(mx > my && mx > mz)  
            return new Vector3((v.Z > 0) ? 1 : -1, 0, 0);
        
        if(my > mz) 
            return new Vector3(0, (v.Y > 0) ? 1 : -1, 0);
        
        return new (0, 0, (v.Z > 0) ? 1 : -1);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Normal(this Vector3 v, int which)
    {
        var n = new Vector3();

        // Arbitrarily choose one vector that's normal to us, pivoting
        // appropriately.
        float xa = MathF.Abs(v.X), ya = MathF.Abs(v.Y), za = MathF.Abs(v.Z);
        if(v.Equals(new Vector3(0, 0, 1))) 
        {
            // Make DXFs exported in the XY plane work nicely...
            n = new Vector3(1, 0, 0);
        } 
        else if(xa < ya && xa < za) 
        {
            n.X = 0;
            n.Y = v.Z;
            n.Z = -v.Y;
        } 
        else if(ya < za) 
        {
            n.X = -v.Z;
            n.Y = 0;
            n.Z = v.X;
        } 
        else 
        {
            n.X = v.Y;
            n.Y = -v.X;
            n.Z = 0;
        }

        if(which == 0)
        {
            // That's the vector we return.
        } 
        else if(which == 1) 
        {
            n = Vector3.Cross(v,n);
        } 
        else 
            throw new Exception("Unexpected vector normal index");

        n = n.WithMagnitude(1);

        return n;
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 ScaledBy(this Vector3 v3, floating v)
    {
        return Vector3.Multiply(v3, v);
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Plus(this Vector3 v3, Vector3 v)
    {
        return Vector3.Add(v3, v);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Minus(this Vector3 v3, Vector3 v)
    {
        return Vector3.Subtract(v3, v);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Cross(this Vector3 v3, Vector3 v)
    {
        return Vector3.Cross(v3, v);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static floating Magnitude(this Vector3 v)
    {
        return v.Length();
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static floating Dot(this Vector3 v, Vector3 b)
    {
        return Vector3.Dot(v, b);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 WithMagnitude(this Vector3 v3, floating v)
    {
        var m = v3.Magnitude();
        if ((m == 0))
        {
            // We can do a zero vector with zero magnitude, but not any other cases.
            if (MathF.Abs(v) > 1e-100)
                throw new ArgumentException("Magnitude of a Zero Vector!");
            
            return new Vector3(0, 0, 0);
        }

        return v3.ScaledBy((v / m));
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Element(this Vector3 v, int i)
    {
        switch (i) 
        {
            case 0: return v.X;
            case 1: return v.Y;
            case 2: return v.Z;
            default: throw new Exception("Unexpected vector element index");
        } 
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ClosestPointBetweenLines(Vector3 a0, Vector3 da, Vector3 b0, Vector3 db,out floating ta,out floating tb)
    {
        // Make a semi-orthogonal coordinate system from those directions;
        // note that dna and dnb need not be perpendicular.
        var dn = Vector3.Cross(da,db); // normal to both
        var dna = Vector3.Cross(dn,da); // normal to da
        var dnb = Vector3.Cross(dn,db); // normal to db

        // At the intersection of the lines
        //    a0 + pa*da = b0 + pb*db (where pa, pb are scalar params)
        // So dot this equation against dna and dnb to get two equations
        // to solve for da and db
        tb =  ((a0.Minus(b0)).Dot(dna))/(db.Dot(dna));
        ta = -((a0.Minus(b0)).Dot(dnb))/(da.Dot(dnb));
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 AtIntersectionOfLines(Vector3 a0, Vector3 a1, Vector3 b0, Vector3 b1, ref bool skew, out floating parama,out floating paramb)
    {
        var da = a1.Minus(a0);
        var db = b1.Minus(b0);
        
        ClosestPointBetweenLines(a0, da, b0, db, out parama, out paramb);
        
        // And from either of those, we get the intersection point.
        var pi = a0.Plus(da.ScaledBy(parama));

        if(skew) 
        {
            // Check if the intersection points on each line are actually
            // coincident...
            if(pi.Equals(b0.Plus(db.ScaledBy(paramb)))) 
            {
                skew = false;
            } else {
                skew = true;
            }
        }
        return pi;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float DistanceToPlane(this Vector3 v3, Vector3 normal, Vector3 origin)
    {
        return v3.Dot(normal) - origin.Dot(normal);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 RotatedAbout(this Vector3 v3, Vector3 orig, Vector3 axis, floating theta)
    {
        var r = v3.Minus(orig);
        r = r.RotatedAbout(axis, theta);
        return r.Plus(orig);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 RotatedAbout(this Vector3 v, Vector3 axis, floating theta) 
    {
        var c = MathF.Cos(theta);
        var s = MathF.Sin(theta);
        axis = axis.WithMagnitude(1);

        return new Vector3
        {
            X = (float)((v.X)*(c + (1 - c)*(axis.X)*(axis.X)) +
                        (v.Y)*((1 - c)*(axis.X)*(axis.Y) - s*(axis.Z)) +
                        (v.Z)*((1 - c)*(axis.X)*(axis.Z) + s*(axis.Y))),
            Y = (float)((v.X)*((1 - c)*(axis.Y)*(axis.X) + s*(axis.Z)) +
                        (v.Y)*(c + (1 - c)*(axis.Y)*(axis.Y)) +
                        (v.Z)*((1 - c)*(axis.Y)*(axis.Z) - s*(axis.X))),
            Z = (float)((v.X)*((1 - c)*(axis.Z)*(axis.X) - s*(axis.Y)) +
                        (v.Y)*((1 - c)*(axis.Z)*(axis.Y) + s*(axis.X)) +
                        (v.Z)*(c + (1 - c)*(axis.Z)*(axis.Z)))
        };
    }
    
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 ClosestPointOnLine(this Vector3 v3, Vector3 p0, Vector3 dp) 
    {
        dp = dp.WithMagnitude(1);
        // this, p0, and (p0+dp) define a plane; the min distance is in
        // that plane, so calculate its normal
        var pn = (v3.Minus(p0)).Cross(dp);
        // The minimum distance line is in that plane, perpendicular
        // to the line
        var n = pn.Cross(dp);
        // Calculate the actual distance
        var d = (dp.Cross(p0.Minus(v3))).Magnitude();
        return v3.Plus(n.WithMagnitude(d));
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static floating DivProjected(this Vector3 v3, Vector3 delta)
    {
        return (v3.X*delta.X + v3.Y*delta.Y + v3.Z*delta.Z) / (delta.X*delta.X + delta.Y*delta.Y + delta.Z*delta.Z);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 FromColorBytes(byte x, byte y, byte z)
    {
        return new Vector3(x/255.1f,y/255.1f,z/255.1f);
    }
}