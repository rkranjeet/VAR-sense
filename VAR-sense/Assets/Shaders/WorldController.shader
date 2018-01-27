Shader "iOSDev/WorldController"
{
	Properties
	{
		_Color ("Color", Color) = (1,1,1,1)
		[Enum(World1,3,World2,6)] _World ("World value", int) = 6
	}
	SubShader
	{
		Color [_Color]
		Stencil
		{
			Ref 1
			Comp [_World]
		}
		Pass{}
	}
}
