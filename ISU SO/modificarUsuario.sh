#!/bin/bash

clear 
tput cup 3 3; read -p "Ingrese la ci del usuario a modificar " ci
busqueda=$(cut -d: -f5 | grep -n "^$ci:" /etc/passwd)  #Guardar la linea ¿es con -n?
if [ -z $busqueda  ]
then
	tput cup 2 3; read -p  "No existe usuario con esa CI" aux
else
	Logg=$(sed -$busqueda | cur -d: -f1) #Buscar el usuario en la linea $busqueda y lo guarda en $Userr
	tput cup 3 3; echo "Dato a modificar de $Userr, ci: $ci"
	tput cup 4 3; echo "1) Directorio de trabajo "
	tput cup 5 3; echo "2) Cedula"
	tput cup 6 3; echo "3) Grupo"
	tput cup 7 3; echo "4) Log"
	tput cup 8 3; echo "5) Levantar baja logica"
	tput cup 9 3; echo "6) Atras"
	tput cup 10 3; read op
	
	case $op in
	1)clear
		tput cup 3 3; read -p "Ingrese el nombre del nuevo directorio de trabajo"
		if [ -d $Homee ] 
		then
			if sudo usermod -d $Homee $Userr
			then
				tput cup 2 3; tput setaf 2; read -p "El directorio de trabajo de $Userr fue cambiado a $Homee"; tput setaf 0
			else
				tput cup 2 3; tput setaf 2; read -p "Error";tput setaf 0
			fi
		else
			tput cup 2 3; tput setaf 1; read -p "El directorio $Homee no es valido";tput setaf 0
		fi
	;;
	2)clear
		tput cup 3 3; read -p "Ingrese CI nueva" CI
		if sudo usermod -c $CI $Userr
		then
			tput cup 2 3; tput setaf 2; read -p "CI de $Userr fue cambiado a $CI"; tput setaf 0
		else
			tput cup 2 3; tput setaf 1; read -p "Error";tput setaf 0
		fi
	;;
	3) clear
		tput cup 3 3; read -p "Ingrese el grupo nuevo" Groupp
		busqueda=$(cut -d: -f3 | grep "$Groupp" etc/group)
		if [ -z $busqueda ]
		then
			tput cup 2 3; tput setaf 1; read -p "Ingrese un grupo valido" aux; tput setaf 0
		else
			busqueda=$(grep "^$Groupp" etc/group)
			if [ -z $busqueda ]
			then
				if  sudo usermod -c $CI $Userr
				then
					tput cup 2 3; tput setaf 2; read -p "CI de $Userr fue cambiado a $CI"; tput setaf 0
				else
					tput cup 2 3; tput setaf 1; read -p "Error";tput setaf 0
				fi
			else 
				tput cup 2 3; tput setaf 1; read -p "Ingrese un grupo valido" aux; tput setaf 0
			fi
		fi
	;;
	4) clear
		tput cup 3 3; read -p "Ingrese el login nuevo" Logg
		busqueda=$(grep "^$Logg" etc/passwd)
		if [ -z $busqueda ]
		then
			if  sudo usermod -l $Logg $Userr
			then
				tput cup 2 3; tput setaf 2; read -p "el login de $Userr fue cambiado a $Logg"; tput setaf 0
			else
				tput cup 2 3; tput setaf 1; read -p "Error";tput setaf 0
			fi
		else
			tput cup 2 3; tput setaf 1; read -p "Ingrese un login valido" aux; tput setaf 0
		fi
	;;
	5) if  sudo usermod -U $Userr
		then
			tput cup 2 3; tput setaf 2; read -p "el login de $Userr fue cambiado a $Logg"; tput setaf 0
		else
			tput cup 2 3; tput setaf 1; read -p "Error";tput setaf 0
		fi
	;;
	6);;
	*);;
esac
	
if [ $op -ne 6 ]
then
	. menuAnterior.sh
fi
	
	