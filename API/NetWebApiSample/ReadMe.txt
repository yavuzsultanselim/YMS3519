//NetWeBapiSample Project


----------------------------
**Database Access Layer - ClassLibrary(.Net Framework)
**Business Logic Layer (Api.Service) -Asp.Net WebApplication (.Net Framework)
**Presentaion Layer (User Interface) - MVC

-----------------------------------------
**DAL
	--Entity
		--Product
			-ID
			-ProductName
			-UnitPrice
			-UnitsInStock
		--AppUser
			-ID
			-UserName
			-Password
	--Context
		--AppDbContext

--enable-migartions i�leminden sonra olu�turulan configuration.cs isimli nesnede bulunan Seed isimli metot i�erisine veritaban� olu�turulurken beraberinde tan�mlanacak olan �rnek �r�nleri ve kullan�c�lar� tan�ml�yoruz.

--daha sonra update-database komutunu girerek tan�mlam�� oldu�umuz tablolar� ve �rnek verileri veritaban�na aktar�yoruz.

----------------------------------
**Api.Service
	--Product Crud i�lemleri tan�mland�

-----------------------------------
**UI
	--index.html isminde bo� bir tema olu�turuldu. 
	--Api.Service i�erisinde tan�ml� olan �r�nler index.html i�erisinde listendi.
	--Api katman�na nuget package manager dan Microsoft.WebApi.Cors k�t�phanesini dahil ederek ard�ndan App_Start i�erisinde bulunan WebApiConfig.cs i�erisine Cors tan�mlamas�n� yapman�z gerekmektedir.
	
	
