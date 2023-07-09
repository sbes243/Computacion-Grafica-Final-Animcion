#version 330 core
out vec4 FragColor;

in vec3 Normal;  
in vec3 FragPos; 

uniform vec3 lightPos; 
uniform vec3 viewPos; 
uniform vec3 lightColor;
uniform vec3 objectColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture samplers
uniform sampler2D texture1;


void main()
{
	// linearly interpolate between both textures (80% container, 20% awesomeface)
	//FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);

	//only texture
	//FragColor = texture(texture1, TexCoord);

	FragColor = texture(texture1, TexCoord) * vec4(ourColor, 1.0);  
}
