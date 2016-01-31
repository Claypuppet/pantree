// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:False,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,rfrpo:False,rfrpn:Refraction,coma:15,ufog:False,aust:False,igpj:False,qofs:0,qpre:2,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:34118,y:33556,varname:node_3138,prsc:2|emission-940-OUT;n:type:ShaderForge.SFN_Color,id:7279,x:32919,y:33229,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_7279,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.75,c2:0.9896551,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2d,id:2548,x:32235,y:34067,varname:node_2548,prsc:2,tex:b7926419c3c0980418762e580f0fd112,ntxv:0,isnm:False|UVIN-283-OUT,TEX-7960-TEX;n:type:ShaderForge.SFN_TexCoord,id:9251,x:31623,y:33707,varname:node_9251,prsc:2,uv:0;n:type:ShaderForge.SFN_Time,id:5138,x:31623,y:33850,varname:node_5138,prsc:2;n:type:ShaderForge.SFN_Slider,id:7017,x:31167,y:34069,ptovrint:False,ptlb:U_Speed_1,ptin:_U_Speed_1,varname:node_7017,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0.01,max:1;n:type:ShaderForge.SFN_Add,id:283,x:32018,y:34067,varname:node_283,prsc:2|A-9251-UVOUT,B-3614-OUT;n:type:ShaderForge.SFN_Append,id:2642,x:31573,y:34102,varname:node_2642,prsc:2|A-7017-OUT,B-5227-OUT;n:type:ShaderForge.SFN_Slider,id:5227,x:31167,y:34162,ptovrint:False,ptlb:V_Speed_1,ptin:_V_Speed_1,varname:node_5227,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:-10;n:type:ShaderForge.SFN_Multiply,id:3614,x:31786,y:34083,varname:node_3614,prsc:2|A-5138-T,B-2642-OUT;n:type:ShaderForge.SFN_Tex2d,id:9285,x:32208,y:33491,varname:node_9285,prsc:2,tex:b7926419c3c0980418762e580f0fd112,ntxv:0,isnm:False|UVIN-6463-OUT,TEX-7960-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:7960,x:31912,y:33766,ptovrint:False,ptlb:node_7960,ptin:_node_7960,varname:node_7960,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b7926419c3c0980418762e580f0fd112,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:1394,x:31191,y:33556,ptovrint:False,ptlb:U_Speed_2,ptin:_U_Speed_2,varname:node_1394,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.01,max:1;n:type:ShaderForge.SFN_Slider,id:5699,x:31191,y:33660,ptovrint:False,ptlb:V_Speed_2,ptin:_V_Speed_2,varname:node_5699,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:-10;n:type:ShaderForge.SFN_Append,id:5985,x:31560,y:33560,varname:node_5985,prsc:2|A-1394-OUT,B-5699-OUT;n:type:ShaderForge.SFN_Add,id:6463,x:31935,y:33416,varname:node_6463,prsc:2|A-9251-UVOUT,B-4479-OUT;n:type:ShaderForge.SFN_Multiply,id:4479,x:31739,y:33507,varname:node_4479,prsc:2|A-5138-T,B-5985-OUT;n:type:ShaderForge.SFN_Blend,id:6328,x:32542,y:33760,varname:node_6328,prsc:2,blmd:17,clmp:False|SRC-9285-RGB,DST-2548-RGB;n:type:ShaderForge.SFN_OneMinus,id:8002,x:32919,y:33394,varname:node_8002,prsc:2|IN-6328-OUT;n:type:ShaderForge.SFN_Multiply,id:8892,x:33151,y:33377,varname:node_8892,prsc:2|A-7279-RGB,B-8002-OUT,C-5811-OUT;n:type:ShaderForge.SFN_Slider,id:5811,x:32846,y:33554,ptovrint:False,ptlb:Multiplier 2,ptin:_Multiplier2,varname:node_5811,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:4;n:type:ShaderForge.SFN_Tex2d,id:1384,x:33164,y:33669,ptovrint:False,ptlb:node_1384,ptin:_node_1384,varname:node_1384,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:5abffc254b3609844ac02ac456fdb687,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:1206,x:33401,y:34370,ptovrint:False,ptlb:node_1206,ptin:_node_1206,varname:node_1206,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9105b1fb910618847a3d0501a6062e02,ntxv:0,isnm:False|UVIN-9042-OUT;n:type:ShaderForge.SFN_Multiply,id:1299,x:33433,y:33647,varname:node_1299,prsc:2|A-8892-OUT,B-1384-RGB,C-8333-OUT;n:type:ShaderForge.SFN_Slider,id:8333,x:33007,y:33872,ptovrint:False,ptlb:Multiplier 3,ptin:_Multiplier3,varname:node_8333,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.5,max:10;n:type:ShaderForge.SFN_Add,id:9042,x:33201,y:34370,varname:node_9042,prsc:2|A-7550-UVOUT,B-2703-OUT;n:type:ShaderForge.SFN_TexCoord,id:7550,x:33008,y:34297,varname:node_7550,prsc:2,uv:0;n:type:ShaderForge.SFN_Slider,id:7005,x:32645,y:34536,ptovrint:False,ptlb:Fade,ptin:_Fade,varname:node_7005,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-100,cur:0,max:0;n:type:ShaderForge.SFN_Multiply,id:940,x:33907,y:33937,varname:node_940,prsc:2|A-1299-OUT,B-7900-OUT;n:type:ShaderForge.SFN_Append,id:2703,x:33008,y:34447,varname:node_2703,prsc:2|A-7132-OUT,B-7005-OUT;n:type:ShaderForge.SFN_Slider,id:7132,x:32645,y:34440,ptovrint:False,ptlb:Append,ptin:_Append,varname:node_7132,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Clamp01,id:8624,x:33599,y:34387,varname:node_8624,prsc:2|IN-1206-RGB;n:type:ShaderForge.SFN_OneMinus,id:7900,x:33814,y:34303,varname:node_7900,prsc:2|IN-8624-OUT;proporder:7017-5227-7279-7960-1394-5699-5811-1384-8333-1206-7005-7132;pass:END;sub:END;*/

Shader "Shader Forge/sdr_LifeLine" {
    Properties {
        _U_Speed_1 ("U_Speed_1", Range(-1, 1)) = 0.01
        _V_Speed_1 ("V_Speed_1", Range(0, -10)) = 0
        _Color ("Color", Color) = (0.75,0.9896551,1,1)
        _node_7960 ("node_7960", 2D) = "white" {}
        _U_Speed_2 ("U_Speed_2", Range(0, 1)) = 0.01
        _V_Speed_2 ("V_Speed_2", Range(0, -10)) = 0
        _Multiplier2 ("Multiplier 2", Range(0, 4)) = 1
        _node_1384 ("node_1384", 2D) = "white" {}
        _Multiplier3 ("Multiplier 3", Range(0, 10)) = 1.5
        _node_1206 ("node_1206", 2D) = "white" {}
        _Fade ("Fade", Range(-100, 0)) = 0
        _Append ("Append", Range(0, 1)) = 0
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _U_Speed_1;
            uniform float _V_Speed_1;
            uniform sampler2D _node_7960; uniform float4 _node_7960_ST;
            uniform float _U_Speed_2;
            uniform float _V_Speed_2;
            uniform float _Multiplier2;
            uniform sampler2D _node_1384; uniform float4 _node_1384_ST;
            uniform sampler2D _node_1206; uniform float4 _node_1206_ST;
            uniform float _Multiplier3;
            uniform float _Fade;
            uniform float _Append;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_5138 = _Time + _TimeEditor;
                float2 node_6463 = (i.uv0+(node_5138.g*float2(_U_Speed_2,_V_Speed_2)));
                float4 node_9285 = tex2D(_node_7960,TRANSFORM_TEX(node_6463, _node_7960));
                float2 node_283 = (i.uv0+(node_5138.g*float2(_U_Speed_1,_V_Speed_1)));
                float4 node_2548 = tex2D(_node_7960,TRANSFORM_TEX(node_283, _node_7960));
                float4 _node_1384_var = tex2D(_node_1384,TRANSFORM_TEX(i.uv0, _node_1384));
                float2 node_9042 = (i.uv0+float2(_Append,_Fade));
                float4 _node_1206_var = tex2D(_node_1206,TRANSFORM_TEX(node_9042, _node_1206));
                float3 emissive = (((_Color.rgb*(1.0 - abs(node_9285.rgb-node_2548.rgb))*_Multiplier2)*_node_1384_var.rgb*_Multiplier3)*(1.0 - saturate(_node_1206_var.rgb)));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
