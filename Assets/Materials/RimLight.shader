Shader "Custom/DiffuseRimlight"
{
        // These are the fields that will appear for this Material in the Inspector - see Unity doc at http://docs.unity3d.com/Documentation/Components/SL-Properties.html
        // The first part is the property's variable, eg. "_MainTex" - Naming your main texture "_MainTex" signals to Unity that this Shader should be included in Lightmap calculations
        // Using the standard Unity property names also lets Unity apply a fallback Shader if the user's hardware can't handle this one
        // The second part in brackets is the name of the property in the Inspector, eg. "Main Texture" - This can be anything you like.
        // The third part in brackets is the variable type, eg. "2D" declares it to be a texture file -
        // The fourth part is the property's default value, eg. "white {}" - Textures are generally given default values of white, gray or black
        Properties
        {
                _MainTex ("Main Texture", 2D) = "white" {} // This is the material's Texture property and we want it to be included in Lightmap calculations (especially LightProbes)
                _RimColor ("Rim Color", Color) = (0.26, 0.19, 0.16, 0.0) // This is the material's RimLight Color
                _RimPower ("Rim Power", float) = 3.0 // This is the material's RimLight strength.  0 will be maximum rimlighting... Rim power is generally exposed as a Range property type
        }
       
        // The SubShader is where the Shader calculations actually happen.
        SubShader
        {
       
                // This allows Unity to intelligently substitute this Shader when needed
                Tags { "RenderType"="Opaque" }
                LOD 200
               
               
                Cull Back
               
                // The syntax that was use after "pragma" tells Unity what kind of shader this is and how it should be applied, eg.
                // This shader is a surface Shader of type Lambert, and we want Unity to approximate view direction to speed up calculations
                CGPROGRAM
                #pragma surface surf Lambert approxview
 
                //These match the shader properties
                uniform sampler2D _MainTex;
                uniform fixed4 _Color, _RimColor;
                uniform fixed _RimPower;
 
        // This contains the inputs to the surface function
                // Valid fields are listed at: http://docs.unity3d.com/Documentation/Components/SL-SurfaceShaders.html
                struct Input
                {
                        float2 uv_MainTex;
                        float3 viewDir; // Since this is a RimLight Shader, we need to account for the Camera View Direction.  This value accesses Unity's internal calculations
                        float3 worldNormal; // Since this is a Mobile Shader, we want to try to avoid complex calculations.  This value uses the Unity's world normals instead of the object normals
                };
 
                // This is where we prepare the surface for lighting by propagating a SurfaceOutput structure
                void surf (Input IN, inout SurfaceOutput o)
                {
                        fixed4 c = tex2D (_MainTex, IN.uv_MainTex); // Samples the texture
                        o.Albedo = c.rgb; // Modulate by main colour
                        o.Alpha = 1.0; // No alpha in this shader
                       
                        fixed3 VdotN = dot(normalize(IN.viewDir), IN.worldNormal); // Here, we calculate what is called the "dot product", basically the effect that a light has based on the angle of a vertex
                       
                        fixed rim = 1.0 - saturate(VdotN); // Here, we calculate the effect of the rim light based on the dot product
                       
                        o.Emission = _RimColor.rgb * pow (rim, _RimPower); // We apply our rim light and place it in the Material's emmission value
                }
                ENDCG
        }
        FallBack "Mobile/Diffuse" // Shader to use if the user's hardware cannot incorporate this one
}