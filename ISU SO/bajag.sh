#!/bin/bash

clear 
#FALTA WHILE
tput cup 3 3; echo "Dato con el que se eliminara"
tput cup 4 3; echo "1) GID" #es unico?
tput cup 5 3; echo "2) Nombre de grupo"
tput cup 6 3; echo "3) Menu de grupo"
tput cup 7 3; read op
clear
case $op in 

	1) tput cup 3 3; read -p "Ingrese el GID a eliminar: " grupo

		aux=$(grep "^$grupo:" /etc/passwd)

		if [ -z $aux  ]
		then
			tput cup 4 3; read -p  "No existe el GID. Presione ENTER para continuar..." aux
		else 
			usermod -L $grupo  #baja lógica
			tput cup 2 3; echo "El grupo $grupo fue eliminado"
		fi
	;;
	2) tput cup 3 3; read -p "Ingrese el Nombre a eliminar a eliminar: " grupo

		aux=$(grep -n "^$grupo:" /etc/passwd)  #Guardar la linea ¿es con -n?

		if [ -z $aux  ]
		then
			tput cup 4 3; read -p  "No existe el grupo. Presione ENTER para continuar..." aux
		else
			grupo= $(cut -d: -f3 $aux)
			usermod -L $grupo
			tput cup 2 3; echo "el grupo $grupo fue eliminado"
		fi
	;;
	3) 
	;;
	*)tput cup 2 3; tput setaf 1; read -p "Ingrese un dato valido" aux; tput setaf 0
	;;

esac

