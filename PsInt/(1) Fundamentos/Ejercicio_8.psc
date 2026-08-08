// Escribe un programa que calcule el sen, coseno y tangente de un
// angulo introducido por el usuario en grados
// Nota: Recuerda que 360 son igual a 2 pi radianes
Algoritmo Angulo
	Definir ang Como Real
	Escribir ("Escribe un Angulo en grados")
	Leer ang
	
	radian <- ang*2*pi/360
	
	seno <- sen(radian)
	coseno <- cos(radian)
	tangente <- tan(radian)
	Escribir("Seno: " + ConvertirATexto(seno))
	Escribir("Coseno: " + ConvertirATexto(coseno))
	Escribir("Tangente: " + ConvertirATexto(tangente))
FinAlgoritmo
