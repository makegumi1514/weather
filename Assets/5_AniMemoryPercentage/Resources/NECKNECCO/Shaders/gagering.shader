// Shader created with Shader Forge v1.24 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.24;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:True,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:False,igpj:False,qofs:0,qpre:2,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True;n:type:ShaderForge.SFN_Final,id:4795,x:33030,y:32623,varname:node_4795,prsc:2|emission-9267-OUT,clip-5016-OUT;n:type:ShaderForge.SFN_TexCoord,id:3199,x:31623,y:32733,varname:node_3199,prsc:2,uv:0;n:type:ShaderForge.SFN_ComponentMask,id:2746,x:31979,y:32733,varname:node_2746,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-6888-OUT;n:type:ShaderForge.SFN_Lerp,id:9267,x:32360,y:32591,varname:node_9267,prsc:2|A-9980-RGB,B-7084-RGB,T-8270-OUT;n:type:ShaderForge.SFN_Color,id:9980,x:32084,y:32476,ptovrint:False,ptlb:Color,ptin:_Color,varname:_node_8303_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4330629,c2:1,c3:0.04411763,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:4725,x:31989,y:32952,ptovrint:False,ptlb:RingBalue,ptin:_RingBalue,varname:node_4725,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3;n:type:ShaderForge.SFN_RemapRange,id:6888,x:31796,y:32733,varname:node_6888,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-3199-UVOUT;n:type:ShaderForge.SFN_Multiply,id:5016,x:32540,y:32962,varname:node_5016,prsc:2|A-5455-OUT,B-4908-OUT,C-786-OUT;n:type:ShaderForge.SFN_ArcTan2,id:6655,x:32151,y:32733,varname:node_6655,prsc:2,attp:2|A-2746-G,B-2746-R;n:type:ShaderForge.SFN_Slider,id:8270,x:31953,y:32637,ptovrint:False,ptlb:Mater,ptin:_Mater,varname:node_8270,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5269514,max:1;n:type:ShaderForge.SFN_Length,id:1180,x:31935,y:33049,varname:node_1180,prsc:2|IN-6888-OUT;n:type:ShaderForge.SFN_Add,id:9477,x:32149,y:32991,varname:node_9477,prsc:2|A-4725-OUT,B-1180-OUT;n:type:ShaderForge.SFN_Floor,id:449,x:32149,y:33126,varname:node_449,prsc:2|IN-1180-OUT;n:type:ShaderForge.SFN_OneMinus,id:786,x:32316,y:33126,varname:node_786,prsc:2|IN-449-OUT;n:type:ShaderForge.SFN_Floor,id:4908,x:32316,y:32991,varname:node_4908,prsc:2|IN-9477-OUT;n:type:ShaderForge.SFN_Multiply,id:9184,x:32854,y:32749,varname:node_9184,prsc:2|A-9267-OUT,B-5016-OUT;n:type:ShaderForge.SFN_Ceil,id:8184,x:32478,y:32733,varname:node_8184,prsc:2|IN-577-OUT;n:type:ShaderForge.SFN_OneMinus,id:5455,x:32637,y:32733,varname:node_5455,prsc:2|IN-8184-OUT;n:type:ShaderForge.SFN_Subtract,id:577,x:32323,y:32733,varname:node_577,prsc:2|A-6655-OUT,B-1018-OUT;n:type:ShaderForge.SFN_Tex2d,id:7084,x:32084,y:32291,ptovrint:False,ptlb:Texture,ptin:_Texture,varname:node_7084,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:1018,x:32149,y:32912,ptovrint:False,ptlb:GageValue,ptin:_GageValue,varname:_Mater_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.6465475,max:1;proporder:9980-4725-8270-7084-1018;pass:END;sub:END;*/

Shader "Custom/gagering" {
    Properties {
        _Color ("Color", Color) = (0.4330629,1,0.04411763,1)
        _RingBalue ("RingBalue", Float ) = 0.3
        _Mater ("Mater", Range(0, 1)) = 0.5269514
        _Texture ("Texture", 2D) = "white" {}
        _GageValue ("GageValue", Range(0, 1)) = 0.6465475
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
        [MaterialToggle] PixelSnap ("Pixel snap", Float) = 0
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
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #pragma multi_compile _ PIXELSNAP_ON
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _Color;
            uniform float _RingBalue;
            uniform float _Mater;
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            uniform float _GageValue;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                #ifdef PIXELSNAP_ON
                    o.pos = UnityPixelSnap(o.pos);
                #endif
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
/////// Vectors:
                float2 node_6888 = (i.uv0*2.0+-1.0);
                float2 node_2746 = node_6888.rg;
                float node_1180 = length(node_6888);
                float node_5016 = ((1.0 - ceil((((atan2(node_2746.g,node_2746.r)/6.28318530718)+0.5)-_GageValue)))*floor((_RingBalue+node_1180))*(1.0 - floor(node_1180)));
                clip(node_5016 - 0.5);
////// Lighting:
////// Emissive:
                float4 _Texture_var = tex2D(_Texture,TRANSFORM_TEX(i.uv0, _Texture));
                float3 node_9267 = lerp(_Color.rgb,_Texture_var.rgb,_Mater);
                float3 emissive = node_9267;
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
