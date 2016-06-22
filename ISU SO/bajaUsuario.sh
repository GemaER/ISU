#!/bin/bash

clear 
#FALTA WHILE
tput cup 3 3; echo "Dato que ingresara"
tput cup 4 3; echo "1) Login"
tput cup 5 3; echo "2) Cedula"
tput cup 6 3; read op
DnLogg=1 
case $op in 
	1) tput cup 3 3; read -p "Ingrese el usuario a eliminar: " Logg
		busqueda=$(grep "^$Logg:" /etc/passwd)
		if [ -z $aux  ]
		then
			DnLogg=0
			tput cup 2 3; tput setaf 1; read -p  "No existe el usuario" aux ; tput setaf 0
		fi
	;;
	2) tput cup 3 3; read -p "Ingrese la cedula a eliminar: " CI
		busqueda=$(grep -n "^$CI:" /etc/passwd)  #Guardar la linea ¿es con -n?
		if [ -z $busqueda  ]
		then
			DnLogg=0
		else
			Logg $(cut -d: -f1 $CI)
		fi
	;;
	*)tput cup 2 3; tput setaf 1; read -p "Ingrese un dato valido" aux; tput setaf 0
	;;
esac
if [ DnLogg -eq 1 ]
then
	tput cup 2 3; tput setaf 1; read -p  "No existe el usuario" aux ; tput setaf 0
else
clear
	tput cup 3 3; echo "1) Baja logica de $Logg"
	tput cup 4 3; echo "1) Eliminacion de $Logg"
	tput cup 5 3; read op
	case $op in 
		1) usermod -L $Logg
		;;
		2) 	clear
			tput cup 3 3; read -p "Eliminar el home (S/N) " eliminar
			case $eliminar in
			"S"||"s") if userdel -r $Logg 
						then
						tput cup 2 3; tput setaf 2; read -p  "Se eliminó el home y registro de $Logg" aux ; tput setaf 0
						fi
			;;
			"N"||"n") if userdel $Logg 
						then
						tput cup 2 3; tput setaf 2; read -p  "Se eliminó el registro de $Logg" aux ; tput setaf 0
						fi
			;;
			*) tput cup 2 3; tput setaf 1; read -p "Ingrese un dato valido" aux; tput setaf 0
			;;
			esac
		*)tput cup 2 3; tput setaf 1; read -p "Ingrese un dato valido" aux; tput setaf 0
		;;
	esac
fi
. menuAnterior.sh
