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

--enable-migartions işleminden sonra oluşturulan configuration.cs isimli nesnede bulunan Seed isimli metot içerisine veritabanı oluşturulurken beraberinde tanımlanacak olan örnek ürünleri ve kullanıcıları tanımlıyoruz.

--daha sonra update-database komutunu girerek tanımlamış olduğumuz tabloları ve örnek verileri veritabanına aktarıyoruz.

----------------------------------
**Api.Service
	--Product Crud işlemleri tanımlandı

-----------------------------------
**UI
	--index.html isminde boş bir tema oluşturuldu. 
	--Api.Service içerisinde tanımlı olan ürünler index.html içerisinde listendi.
	--Api katmanına nuget package manager dan Microsoft.WebApi.Cors kütüphanesini dahil ederek ardından App_Start içerisinde bulunan WebApiConfig.cs içerisine Cors tanımlamasını yapmanız gerekmektedir.
	
	
