#!/bin/bash

clear 
#FALTA WHILE
tput cup 3 3; echo "Dato con el que se eliminara"
tput cup 4 3; echo "1) Nombre de usuario"
tput cup 5 3; echo "2) Cedula"
tput cup 6 3; echo "3) Menu principal"
tput cup 7 3; read op
clear
case $op in 

	1) tput cup 3 3; read -p "Ingrese el usuario a eliminar: " usuario

		aux=$(grep "^$usuario:" /etc/passwd)

		if [ -z $aux  ]
		then
			tput cup 4 3; read -p  "No existe el usuario. Presione ENTER para continuar..." aux
		else 
			usermod -L $usuario  #baja lógica
			tput cup 4 3; echo "El usuario $usuario fue eliminado"
		fi
	;;
	2) tput cup 3 3; read -p "Ingrese la cedula a eliminar: " usuario

		aux=$(grep -n "^$usuario:" /etc/passwd)  #Guardar la linea ¿es con -n?

		if [ -z $aux  ]
		then
			tput cup 4 3; read -p  "No existe el usuario. Presione ENTER para continuar..." aux
		else
			usuario= $(cut -d: -f1 $aux)
			usermod -L $usuario
			tput cup 4 3; echo "el usuario $usuario fue eliminado"
		fi
	;;
	3) 
	;;
	*)tput cup 2 3; tput setaf 1; read -p "Ingrese un dato valido" aux; tput setaf 0
	;;

esac

