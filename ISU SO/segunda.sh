#!/bin/bash
DnGroupp=0
while [ $DnGroupp -eq 0 ]
do
	tput cup 3 3; read -p "Ingrese el grupo a buscar: " Groupp
	aux=$(grep "^$Groupp:" /etc/group)
	if [ -z $aux ] 
	then
		tput cup 2 3; tput setaf 1 ; read -p "Ingrese un dato valido" aux; tput setaf 0
	else 
		DnGroupp=1
		tput cup 2 3; tput setaf 2 ; echo "El grupo $Groupp fue encontrado" ; tput setaf 0 
		aux1=$(echo $aux | cut -d: -f1)
		tput cup 6 3; echo "Grupo: $aux1"
		aux1=$(echo $aux | cut -d: -f3) 
		tput cup 7 3; echo "GID: $aux1"
		aux1=$(echo $aux | cut -d: -f4) 
		tput cup 8 3; echo "Integrantes: "
		#Esto es para que muestre un integrante por linea
		A=1
		campo=1
		linea=8
		var=$(echo $aux1 | grep ",")
		#Para ver si de haber integrantes hay uno o mas, si hay coma hay 2 o mas, si no hay coma hay 0 o 1
		if [ -z $var ]
		then
			nombre_miembro=$(echo $aux1 | cut -f$campo -d',')
			#Para ver si es 0 integrantes o 1 integrante
			if [ -z $nombre_miembro ]
			then
				let linea++
				tput cup $linea 4; echo " "
			else	
				let linea++
				tput cup $linea 4; echo -$nombre_miembro
				let linea++
				tput cup $linea 3; echo " "
			fi	
		else
			while [ $A -eq 1 ]
			do
				nombre_miembro=$(echo $aux1 | cut -f$campo -d',')
				if [ -z $nombre_miembro ]
				then
					A=0
				else
					let linea++
					tput cup $linea 4; echo -$nombre_miembro
					let campo++
				fi
			done
			let linea++
			tput cup $linea 3; echo " "
		fi
		let linea++
		tput cup $linea 3; read -p " " aux
	fi
done
