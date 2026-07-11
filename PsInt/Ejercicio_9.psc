// Escribe un programa que solicite una cantidad de segundos al usuario y
// devuelva la cantidad de horas, minutos y segundos a los
// que equivalen. Por ejemplo:
// 11781 segundos equivalen a 3 horas, 16 minutos y 21 segundos
Algoritmo conversionSegundos9
	Definir seg Como Real
	Escribir "Escribe los segundos a convertir: "
	Leer seg
	horas <- trunc(seg / (60*60))
	segTemp <- seg % (60*60)
	minutos <- trunc(segTemp / 60)
	segTotal <- segTemp % 60
	Escribir seg, " equivale a: "
	Escribir horas, " horas", ", ", minutos, " minutos", ", ", segTotal, "segundos"
	
FinAlgoritmo
