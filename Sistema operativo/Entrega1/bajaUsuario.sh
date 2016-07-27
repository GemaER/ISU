#!/bin/bash
DnBaja=0
while [ $DnBaja -eq 0 ]
do
	clear
	tput cup 3 3; echo "Ingrese el Login o cedula"
	tput cup 4 3;  read CI
	busqueda=$(cut -d: -f5 /etc/passwd | grep -n "$CI" | cut -d: -f1) 
	if [ -z $busqueda  ]
	then
		busqueda=$(cut -d: -f1 /etc/passwd | grep -n "$CI" | cut -d: -f1) 
		if [ -z $busqueda  ]
		then
			tput cup 2 3; tput setaf 1; read -p "Ingrese un grupo valido" aux; tput setaf 0
		else
			Logg=$CI
			DnBaja=1
		fi
	else
		Logg=$(head -$busqueda /etc/passwd | tail -1 | cut -d: -f1 )
		DnBaja=1
	fi
	if [ $DnBaja -eq 1 ]
	then
		clear
		tput cup 3 3; echo "1) Baja logica de $Logg"
		tput cup 4 3; echo "2) Eliminacion de $Logg"
		tput cup 5 3; read op
		case $op in
		1) if sudo usermod -L $Logg
			then
				tput cup 2 3; tput setaf 2; read -p  "Se dio baja logica a $Logg" aux ; tput setaf 0
			else
				 tput cup 2 3; tput setaf 1; read -p "Error" aux; tput setaf 0
			fi
		;;
		2) 	clear
			tput cup 3 3; read -p "Eliminar el home (S/N) " eliminar
			case $eliminar in
			"S"|"s") if sudo userdel -r $Logg 
						then
						tput cup 2 3; tput setaf 2; read -p  "Se eliminó el home y registro de $Logg" aux ; tput setaf 0
						else
							tput cup 2 3; tput setaf 1; read -p "Error" aux; tput setaf 0
						fi
			;;
			"N"|"n") if sudo userdel $Logg 
						then
						tput cup 2 3; tput setaf 2; read -p  "Se eliminó el registro de $Logg" aux ; tput setaf 0
						else
							tput cup 2 3; tput setaf 1; read -p "Error" aux; tput setaf 0
						fi
			;;
			*) tput cup 2 3; tput setaf 1; read -p "Ingrese un dato valido" aux; tput setaf 0
			;;
			esac
		;;
		*) tput cup 2 3; tput setaf 1; read -p "Ingrese un dato valido" aux; tput setaf 0
		;;
		esac
	fi
done