<Query Kind="Statements">
  <Connection>
    <ID>9952c766-60d3-445d-82ac-c52aebd030c0</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-N53NAND\SQLEXPRESS</Server>
    <Database>MonUDQL1</Database>
  </Connection>
</Query>

//câu 1:
Products.Select(product=> product)
//Câu 2:
Products.GroupBy(product=> product.Category)
//Câu 3:
Orders.GroupBy(n => new {n.OrderDate.Value.Year,n.OrderDate.Value.Month})
//c2:
var q3 = from m  in Orders
			group m by new {m.OrderDate.Value.Year,m.OrderDate.Value.Month};
			q3.Dump();
//Câu 4:
var q4 = OrderDetails.Join(
Orders,
odt=> odt.OrderID,
o=> o.OrderID,
(odt,o) => new {odt,o}
).Where(n=> n.odt.Quantity * n.odt.UnitPrice <= 500).Select(m=>m.o);
q4.Dump();
//c2
var q41 = from o in Orders join 
			odt in OrderDetails on o.OrderID equals odt.OrderID
			where odt.Quantity * odt.UnitPrice <= 500
			select new {o};
q41.Dump();
//Câu 5:
Orders.Select(n=> n).Where(n=> n.OrderDate.Value.Year > 1997 )
//Câu 6:
var q6 = OrderDetails.Join(
Orders,
odt=> odt.OrderID,
o=> o.OrderID, 
(odt,o) => new {odt,o}).Join(Customers, 
oodt => oodt.o.CustomerID,
c => c.CustomerID,
(oodt, c) => new{oodt,c})
.Where( m =>  m.c.Country == "USA" && m.oodt.odt.Quantity * m.oodt.odt.UnitPrice > 600).Select(n => n.oodt.o);
q6.Dump();
//Câu 7:
var q7 = Categories.Join(
Products, 
c => c.CategoryID,
p => p.CategoryID,
(c,p) => new{c,p}).Where(m=> m.p.UnitsInStock == 0).Select(m=> m.c).Distinct();
q7.Dump();

//Câu 8:
var q8 = from p in Products 
		join c in Categories on p.CategoryID equals c.CategoryID
		select new {c,p};

if(q8.All(i => i.p.UnitsInStock > 0)){
q8.Distinct().Dump();
}
		

//Câu 9:
var q9 = from o in Orders 
		group o by o.CustomerID into g
         join c in Customers on 
		 g.Key equals c.CustomerID	 
		 select new {
		 CustomerID = g.Key,
         CompanyName = c.CompanyName,
         Count = g.Count()};
 q9.Dump();
//c2:
var q91 = Orders.Join(
Customers, 
o => o.CustomerID,
c => c.CustomerID,
(o,c) => new{o,c}).GroupBy(oc=> new {oc.o.CustomerID,oc.c.CompanyName}).
Select(	kq => new{  kq.Key.CustomerID,
					kq.Key.CompanyName,
					Count = kq.Count()});
q91.Dump();

// Câu 10:
var q10 = Categories.Join(
Products,
c => c.CategoryID,
p => p.CategoryID,
(c,p) => new {c,p}).GroupBy(pc => new{pc.c.CategoryID,pc.c.CategoryName})
.Select(kq => new {kq.Key.CategoryID,
					kq.Key.CategoryName,
					Count = kq.Count()});

q10.Dump();

//Cau 11:
var q11 = from p in Products
			group p by  p.CategoryID into g 
			join c in Categories on g.Key equals c.CategoryID
			select new {
			CatagoryID = c.CategoryID,
			CategoryName = c.CategoryName,
			Sum = g.Sum(p=> p.UnitsInStock),
			};
 q11.Dump();
//câu 12:
var q12 = from p in Products
			group p by  p.CategoryID into g 
			join c in Categories on g.Key equals c.CategoryID
			select new {
			CatagoryID = c.CategoryID,
			CategoryName = c.CategoryName,
			Min = g.Min(p=> p.UnitPrice),
			};
 q12.Dump();
 //Câu 13: 
 var q13 = from p in Products
 			group p by p.CategoryID into g 
			join c in Categories on g.Key equals c.CategoryID
			select new {
			Category = c.CategoryID,
			CategoryName = c.CategoryName,
			ProductIsMost = 
			from p1 in g
			where p1.UnitPrice == g.Min( p2=> p2.UnitPrice)
			select p1};
q13.Dump();
//câu 14
var q14 = from p in Products
			group p by p.CategoryID into g
			join c in Categories on g.Key equals c.CategoryID
			select new {
			CategoryID = c.CategoryID,
			CategoryName = c.CategoryName,
			Max = g.Max(i => i.UnitPrice)};
			
q14.Dump();
//Cau 15: 
var q15 = from p in Products
			group p by p.CategoryID into g
			join c in Categories on g.Key equals c.CategoryID
			select new {
			CategoryID = c.CategoryID,
			CategoryName = c.CategoryName,
			ProcductsIsMAX = 
			from p1 in g
			where p1.UnitPrice == g.Max(i => i.UnitPrice)
			select p1};
			
q15.Dump();
//Cau 16:
var q16 = from p in Products
			group p by p.CategoryID into g
			join c in Categories on g.Key equals c.CategoryID
			select new {
			CategoryID = c.CategoryID,
			CategoryName = c.CategoryName,
			AVG = g.Average(i => i.UnitPrice)
			};			
q16.Dump();