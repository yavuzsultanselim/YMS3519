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

--enable-migartions iþleminden sonra oluþturulan configuration.cs isimli nesnede bulunan Seed isimli metot içerisine veritabaný oluþturulurken beraberinde tanýmlanacak olan örnek ürünleri ve kullanýcýlarý tanýmlýyoruz.

--daha sonra update-database komutunu girerek tanýmlamýþ olduðumuz tablolarý ve örnek verileri veritabanýna aktarýyoruz.

----------------------------------
**Api.Service
	--Product Crud iþlemleri tanýmlandý

-----------------------------------
**UI
	--index.html isminde boþ bir tema oluþturuldu. 
	--Api.Service içerisinde tanýmlý olan ürünler index.html içerisinde listendi.
	--Api katmanýna nuget package manager dan Microsoft.WebApi.Cors kütüphanesini dahil ederek ardýndan App_Start içerisinde bulunan WebApiConfig.cs içerisine Cors tanýmlamasýný yapmanýz gerekmektedir.
	
	
