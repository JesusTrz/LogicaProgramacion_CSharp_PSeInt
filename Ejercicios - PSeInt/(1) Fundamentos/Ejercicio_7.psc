// Escribe un programa que solicite al usuario los tres coeficientes (a, b y c)
// de una ecuación de segundo grado, definida por la siguiente escuación:
// ax^2 + bx + c = 0
// En base a esos coeficientes, se calcularán y mostrarán en la consola las
// dos soluciones de la ecuación, mediante la FORMULA GENERAL
Algoritmo Coeficientes
	Definir a, b, c Como Real
	Escribir "Escrtibe tu coeficiente A: "
	Leer a
	Escribir "Escrtibe tu coeficiente B: "
	Leer b
	Escribir "Escrtibe tu coeficiente C: "
	Leer c
	primerFormula <- (-b + raiz(b*b - 4 * a * c)) / (2*a)
	segundaFormula <- (-b - raiz(b*b - 4 * a * c)) / (2*a)
	Escribir("Coeficientes:" + ConvertirATexto(a) + ", " + ConvertirATexto(b) + ", "+ ConvertirATexto(c))
	Escribir("Solucion de la primer ecuacion: " + ConvertirATexto(primerFormula))
	Escribir("Solucion de la segunda ecuacion: " + ConvertirATexto(segundaFormula))
FinAlgoritmo
