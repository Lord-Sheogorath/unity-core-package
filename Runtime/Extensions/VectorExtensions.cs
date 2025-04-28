using UnityEngine;

namespace LordSheo.Core
{
	public static class VectorExtensions
	{
		public static Vector2 X(this Vector2 source, float x)
		{
			source.x = x;
			return source;
		}
		public static Vector2 Y(this Vector2 source, float y)
		{
			source.y = y;
			return source;
		}
		
		public static Vector3 X(this Vector3 source, float x)
		{
			source.x = x;
			return source;
		}
		public static Vector3 Y(this Vector3 source, float y)
		{
			source.y = y;
			return source;
		}
		public static Vector3 Z(this Vector3 source, float z)
		{
			source.z = z;
			return source;
		}
		
		public static Vector3 XY(this Vector3 source, float x, float y)
		{
			source.x = x;
			source.y = y;
			return source;
		}
		public static Vector3 XZ(this Vector3 source, float x, float z)
		{
			source.x = x;
			source.z = z;
			return source;
		}
		public static Vector3 YZ(this Vector3 source, float y, float z)
		{
			source.y = y;
			source.z = z;
			return source;
		}
	}
}