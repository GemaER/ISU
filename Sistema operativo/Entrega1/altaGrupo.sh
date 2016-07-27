#!/bin/bash
DnAlta=0
while [ $DnAlta -eq 0 ]
do
	clear
	tput cup 3 3; echo "Nombre del grupo :"
	tput cup 4 3; echo "GID :"
	DnGroupp=0
	DnGid=0
	while [ $DnGroupp -eq 0 ]
	do
		tput cup 3 22; read Groupp
		busqueda=$(cut -d: -f1 /etc/group |grep "$Groupp")
		if [ -z $busqueda ]
		then
			DnGroupp=1
			while [  $DnGid -eq 0 ] 
			do
				tput cup 4 9; read GIDD
				busqueda=$(cut -d: -f3 /etc/group | grep "$GIDD")
				if [ -z $busqueda ]
				then
					DnGid=1
					if sudo groupadd -g $GIDD $Groupp
					then
						tput cup 2 3; tput setaf 2; read -p "Grupo $Groupp, creado" aux; tput setaf 0
						DnAlta=1
					else
						tput cup 2 3; tput setaf 1; read -p "Error"; tput setaf 0
					fi
				else
					tput cup 2 3; tput setaf 1; read -p "Ingrese un GID valido" aux; tput setaf 0
				fi
			done
		else
			tput cup 2 3; tput setaf 1; read -p "Ingrese un grupo valido" aux; tput setaf 0	
		fi
	done
done