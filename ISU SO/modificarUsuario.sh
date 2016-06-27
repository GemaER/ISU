#!/bin/bash
DnMenu=0
while [ DnMenu -eq 0 ]
do
	clear
	tput cup 3 3; read -p "Ingrese la ci del usuario a modificar " ci
	busqueda=$(cut -d: -f5  /etc/passwd | grep -n "$ci"|cut -d: -f1) 
	if [ -z $busqueda  ]
	then
		tput cup 2 3; read -p  "No existe usuario con esa CI " aux
	else
		clear
		Logg=$(head -$busqueda /etc/passwd | tail -1 | cut -d: -f1 )
		tput cup 3 3; echo "Dato a modificar de $Logg, ci: $ci"
		tput cup 4 3; echo "1) Directorio de trabajo "
		tput cup 5 3; echo "2) Cedula"
		tput cup 6 3; echo "3) Grupo"
		tput cup 7 3; echo "4) Log"
		tput cup 8 3; echo "5) Levantar baja logica"
		tput cup 9 3; echo "6) Atras"
		tput cup 10 3; read op
		DnMod=0
		while [ $DnMod -eq 0 ]
		do
			clear
			case $op in
			1)	HomeeO=$(head -$busqueda /etc/passwd | tail -1 | cut -d: -f6 )
				tput cup 3 3; read -p "Ingrese el nombre del nuevo directorio de trabajo" Homee
				if sudo usermod -m -d $Homee $Logg
				then
					tput cup 2 3; tput setaf 2; read -p "El directorio de trabajo de $Logg fue cambiado a $Homee " aux; tput setaf 0
					DnMod=1
				else
					tput cup 2 3; tput setaf 1; read -p "Error" aux ;tput setaf 0
				fi
			;;
			2)	DnCI=0
				while [ $DnCI -eq 0 ]
				do
					tput cup 3 3; read -p "Ingrese CI nueva " CI
					echo $CI > aux.txt
					. verificar.sh
					DnCI=$(cat aux2.txt)
				done
				if sudo usermod -c $CI $Logg
				then
					tput cup 2 3; tput setaf 2; read -p "CI de $Logg fue cambiado a $CI" aux; tput setaf 0
					DnMod=1
				else
					tput cup 2 3; tput setaf 1; read -p "Error" aux;tput setaf 0
				fi
			;;
			3) 	tput cup 3 3; read -p "Ingrese el grupo nuevo " Groupp
				busqueda=$(cut -d: -f1 /etc/group | grep "$Groupp")
				if [ -z $busqueda ]
				then
					busqueda=$(cut -d: -f3 /etc/group | grep "$Groupp")
					if [ -z $busqueda ]
					then
						DnMod=1
					else
						tput cup 2 3; tput setaf 1; read -p "Ingrese un grupo valido" aux; tput setaf 0
					fi
				else
					if  sudo usermod -g $Groupp $Logg
					then
						DnMod=1	
					else
						tput cup 2 3; tput setaf 1; read -p "Error" aux ;tput setaf 0
					fi
				fi
				if [ $DnMod -eq 1 ] 
				then
					tput cup 2 3; tput setaf 2; read -p "Grupo de $Logg fue cambiado a $Groupp" aux; tput setaf 0
				fi
			;;
			4) 	tput cup 3 3; read -p "Ingrese el login nuevo " LoggN
				busqueda=$(grep "^$LoggN" /etc/passwd)
				if [ -z $busqueda ]
				then
					if  sudo usermod -l $LoggN $Logg
					then
						tput cup 2 3; tput setaf 2; read -p "el login de $Logg fue cambiado a $LoggN" aux; tput setaf 0
						DnMod=1	
					else	
						tput cup 2 3; tput setaf 1; read -p "Error" aux;tput setaf 0
					fi
				else
					tput cup 2 3; tput setaf 1; read -p "Ingrese un login valido" aux; tput setaf 0
				fi
			;;
			5) if  sudo usermod -U $Logg
				then
					tput cup 2 3; tput setaf 2; read -p "Se levanto la baja logica de $Logg" aux; tput setaf 0
					DnMod=1	
				else
					tput cup 2 3; tput setaf 1; read -p "Error" aux;tput setaf 0
				fi
			;;
			6) DnMod=1
			;;
			*) tput cup 2 3; tput setaf 1; read -p "Ingrese un dato valido" aux; tput setaf 0
			;;
			esac
			if [ $DnMod -eq 1 ]
			then
				DnMenu=1
			fi
		done
	fi
done