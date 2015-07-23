#pragma once

#include "VAO.hpp"
#include "Shader.hpp"
#include <src/engine/anim/Transform.hpp>
#include "Renderable.hpp"

class SolidRectangle: public Renderable
{
private:
    static int attributes[];
    static GLuint indices[];

	float x, y, width, height, r, g, b;
    VAO *vao;
    Shader *shader;

	void constructVAO();

public:
	float getX();
	float getY();
	float getWidth();
	float getHeight();
	float getR();
	float getG();
	float getB();

	SolidRectangle(float width, float height);
    SolidRectangle(float x, float y, float width, float height, float r = 1.0f, float g = 1.0f, float b = 1.0f, double layer = 0);
    ~SolidRectangle();
	void setLayer(double layer);

    void render();
    void render(glm::mat4 transformMatrix);
    Collider &provideCollider();
};