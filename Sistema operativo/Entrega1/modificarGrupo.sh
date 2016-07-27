#!/bin/bash
DnGroupp=0
DnMod=0
while [ $DnGroupp -eq 0 ]
do
	clear
	tput cup 3 3; echo "Grupo o GID a modificar"
	tput cup 4 3;  read GIDD

	busqueda=$(cut -d: -f1 /etc/group |grep -n "$GIDD" | cut -d: -f1 )
	if [ -z $busqueda ]
	then
		busqueda=$(cut -d: -f3 /etc/group | grep -n "$GIDD" | cut -d: -f1)
		if [ -z $busqueda ]
		then
			tput cup 2 3; tput setaf 1; read -p "Ingrese un grupo valido" aux; tput setaf 0
		else
			Groupp=$(head -$busqueda /etc/group | tail -1 | cut -d: -f1 )
			DnGroupp=1
		fi
	else
		Groupp=$GIDD
		DnGroupp=1
	fi 
	if [ $DnGroupp -eq 1 ]
	then
		while [ $DnMod -eq 0 ]
		do
			clear
			tput cup 3 3; echo "Dato a morificar "
			tput cup 4 3; echo "1) Nombre del grupo"
			tput cup 5 3; echo "2) GID"
			tput cup 6 3; read op
			clear
			case $op in
		 	1)
				tput cup 4 3; read -p "Ingrese nuevo nombre " GroupN
				busqueda=$(cut -d: -f1 /etc/group |grep "$GroupN")
				if [ -z $busqueda ]
				then
					if sudo groupmod -n $GroupN $Groupp
					then
						tput cup 2 3;  tput setaf 2; read -p "El grupo $grupo fue modificado por el nombre $GroupN" aux ; tput setaf 0
						DnMod=1
					else
						tput cup 2 3; tput setaf 1; read -p "Error" aux; tput setaf 0
					fi
				else
					tput cup 2 3; tput setaf 1; read -p "Ese nombre ya esta usado" aux; tput setaf 0
				fi
			;;
			2)
				tput cup 4 3; read -p "Ingrese nuevo GID " GIDN
				busqueda=$(cut -d: -f3 /etc/group |grep "$GIDN")
				if [ -z $busqueda ]
				then
					if sudo groupmod -g $GIDN $Groupp
					then
						tput cup 2 3;  tput setaf 2; read -p "El GID de $Groupp fue modificado a $GIDN" aux ; tput setaf 0
						DnMod=1
					else
						tput cup 2 3; tput setaf 1; read -p "Error" aux; tput setaf 0
					fi
				else
					tput cup 2 3; tput setaf 1; read -p "Ese GID ya esta usado" aux; tput setaf 0
				fi
			;;
			3);;
			*) tput cup 2 3; tput setaf 1; read -p "Ingrese un dato valido" aux; tput setaf 0
			esac
		done
	fi
done
