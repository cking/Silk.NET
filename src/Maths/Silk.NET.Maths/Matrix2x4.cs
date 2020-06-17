﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Maths
{
    public struct Matrix2X4<T> : IEquatable<Matrix2X4<T>> where T:unmanaged
    {
        public static readonly Matrix2X4<T> Zero;
        public Vector4<T> Row0;
        public Vector4<T> Row1;

        public Matrix2X4(Vector4<T> row0, Vector4<T> row1)
        {
            throw new NotImplementedException();
        }

        public Matrix2X4
        (
            T m00,
            T m01,
            T m02,
            T m03,
            T m10,
            T m11,
            T m12,
            T m13
        )
        {
            throw new NotImplementedException();
        }

        public Vector2<T> Column0
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector2<T> Column1
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector2<T> Column2
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector2<T> Column3
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Vector2<T> Diagonal
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public T Trace => throw new NotImplementedException();

        public T this[int rowIndex, int columnIndex]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public static void CreateRotation(T angle, out Matrix2X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> CreateRotation(T angle)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T scale, out Matrix2X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> CreateScale(T scale)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(Vector2<T> scale, out Matrix2X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> CreateScale(Vector2<T> scale)
        {
            throw new NotImplementedException();
        }

        public static void CreateScale(T x, T y, out Matrix2X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> CreateScale(T x, T y)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2X4<T> left, T right, out Matrix2X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> Multiply(Matrix2X4<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2X4<T> left, ref Matrix4X2<T> right, out Matrix2X2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X2<T> Multiply(Matrix2X4<T> left, Matrix4X2<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2X4<T> left, ref Matrix4X3<T> right, out Matrix2X3<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> Multiply(Matrix2X4<T> left, Matrix4X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Multiply(ref Matrix2X4<T> left, ref Matrix4X4<T> right, out Matrix2X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> Multiply(Matrix2X4<T> left, Matrix4X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Add(ref Matrix2X4<T> left, ref Matrix2X4<T> right, out Matrix2X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> Add(Matrix2X4<T> left, Matrix2X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Subtract(ref Matrix2X4<T> left, ref Matrix2X4<T> right, out Matrix2X4<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> Subtract(Matrix2X4<T> left, Matrix2X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static void Transpose(ref Matrix2X4<T> mat, out Matrix4X2<T> result)
        {
            throw new NotImplementedException();
        }

        public static Matrix4X2<T> Transpose(Matrix2X4<T> mat)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> operator *(T left, Matrix2X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> operator *(Matrix2X4<T> left, T right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X2<T> operator *(Matrix2X4<T> left, Matrix4X2<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X3<T> operator *(Matrix2X4<T> left, Matrix4X3<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> operator *(Matrix2X4<T> left, Matrix4X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> operator +(Matrix2X4<T> left, Matrix2X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static Matrix2X4<T> operator -(Matrix2X4<T> left, Matrix2X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Matrix2X4<T> left, Matrix2X4<T> right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Matrix2X4<T> left, Matrix2X4<T> right)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Matrix2X4<T> other)
        {
            throw new NotImplementedException();
        }
    }
}