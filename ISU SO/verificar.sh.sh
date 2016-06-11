#!/bin/bash


	come=$(cat aux.txt)
	cont=7    # % ¿realemtne funciona para tomar el resto?
	while [ $come -ge 10 | -o $cont -eq 0] 
	do
	
		bc ci[cont]=$come % 10 # ¿funciona como array con tope/ array list?
		let come=$come / 10    # ¿let solo trabaja conenteros?
		cont=$cont-1
	
	done
	if [ cont -gt 0 ] 
	then
		tput cup 2 3; echo "Faltan digitos"
	else if [ $come -ge 10 ]
		tput cup 2 3; echo "Sobran digitos"
	else
		i=0
		while [ $i -lt 8 ]
		do
			case $i in
			
			0) let ci[i]=ci[i]*2
				acum=%acum+ci[i]
			;;
			1) let ci[i]=ci[i]*9
				acum=%acum+ci[i]
			;;
			2) let ci[i]=ci[i]*8
				acum=%acum+ci[i]
			;;
			3) let ci[i]=ci[i]*7
				acum=%acum+ci[i]
			;;
			4) let ci[i]=ci[i]*6
				acum=%acum+ci[i]
			;;
			5) let ci[i]=ci[i]*3
				acum=%acum+ci[i]
			;;
			6) let ci[i]=ci[i]*4
				acum=%acum+ci[i]
			;;
			7) sig0=$acum
				while [ bc cont=$acum % 10 -ne 0 ]
				do
					
					sig0=$sig0+1
				
				done
				
				let veri=$sig0-$acum
				if [ ci[i] -ne $veri ] 
				then
				
					tput cup 2 25; tput setaf 1; echo "CI invalida"
				else
					verificar=1
					chequeo=$(grep $come /etc/passwd)

					if [ -z $chequeo  ]  #si no existe el usuario con esa ci se peude crear
					then
						echo "1" > aux2.txt
						tput cup 2 3; echo "La CI fue registrada"
					else
						tput cup 2 3; tput setaf 1; echo "CI ya registrada"; tput setaf 0
	
					fi
				fi
			;;
			
				i=i+1
				
			esac
		done
	fi