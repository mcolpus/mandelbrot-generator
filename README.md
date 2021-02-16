# mandelbrot-generator
An app for visualizing the Mandelbrot set, with the ability to use custom equations.

The main logic is contained in FractalGenerator. DynamicLambda is used to convert the given equation (a string) into a function matching the desired delegate.

How Mandelbrot fractals work:
We have an equation such as z = z^2 + c. For each point on the picture we are going to draw we set c to be that location as a complex number. we start with z=0 and repeat the equation until z grows very large. We colour the point based on the number of steps to escape.

For custom equations we can use other powers as well as z.bar (the complex conjugate) and zn1 for the value of z the step before.
So a valid equation may look like: 6*(z^2) + 2*(z.bar^3) - zn1 + c
