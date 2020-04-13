Shader "Unlit/BallShader"
{
	Properties		// unityからパラメータを受け取る
	{

	}

	SubShader		// SubShaderブロック
	{				// 一つ以上存在する
		Pass
		{
			CGPROGRAM
			#pragma vertex vertexFunction
			#pragma fragment fragmentFunction

			#include "UnityCG.cginc"

			struct appdata		// 頂点シェーダ用の構造体
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f			// フラグメントシェーダ用の構造体
			{
				float4 position : SV_POSITION;
				float2 uv : TEXCOORD0;
			};

			v2f vertexFunction(appdata IN) //頂点シェーダの変換
			{
				v2f OUT;
				OUT.position = UnityObjectToClipPos(IN.vertex);
				//オブジェクト空間で表される頂点座標をカメラのクリップ空間に変換する。

				return OUT;
			}

			float4 fragmentFunction(v2f IN) : SV_TARGET	// フラグメントシェーダ
			{
					return fixed4(0,1,0,1);	//(R,G,B,A)
			}

			ENDCG
		}

	}
}
