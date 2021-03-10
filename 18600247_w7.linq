<Query Kind="Statements">
  <Connection>
    <ID>d0f00a32-b047-4a25-a80f-c1c21a15f06e</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-N53NAND\SQLEXPRESS</Server>
    <Database>MonUDQL1</Database>
  </Connection>
</Query>

//câu 1
Enumerable.Range(0,100).Where(i=> i < 5)
//Câu 2: sản phẩm hết hành
Products.Where (p => p.Quantity == 0 )
//Câu 3: còn hàng và giá nhỏ hơn 100
Products.Where (p => p.Quantity != 0).Where( p => p.Price < 100000)
//Câu 4: 
string[] str4= {"zero","one","two", "three", "four","five","six", "sevent", "eight", "night"};
var q4 = str4.Select (n => n).Where((temp,idx) => temp.Count() < idx) ; 
q4.Dump();
//Câu 5:
int [] number5 = {5,4,1,3,9,8,6,7,2,0};
var q5 = number5.Select((n,idx) => n == idx) ;
q5.Dump();
//Câu 6:
string[] str6= {"zero","one","two", "three", "four","five","six", "sevent", "eight", "night"};
var q6 = str6.Select((n,idx) =>  new{n,idx}).Where( (i, idx) => i.idx < 5);
q6.Dump();
//Câu 7:
int [] A = {0,2,4,5,6,8,9};
int [] B = {1,3,5,7,8};
var q7 = from a in A
from b in B
where (a< b)
select  new {a,b};
q7.Dump();
//Câu 8:
int [] number8 = {5,4,1,3,9,8,6,7,2,0};
var q8 = number8.GroupBy(n => n = n % 5);
q8.Dump();
//Câu 9:
string [] str9 = {"blueberry", "chimpanzee", "abacus","banana", "apple","cheese"};
var q9 = str9.GroupBy(n => n.FirstOrDefault());
q9.Dump();
//Câu 10:
string [] str10 = {"cherry" ,"apple", "blueberry"};
var q10 = str10.OrderBy(n=> n.FirstOrDefault());
q10.Dump();
//Câu 11: sắp chuỗi ở câu 10 theo chiều dài (dài nhất ở trên)
var q11 = str10.OrderByDescending(n => n.Count()) ;
q11.Dump();
//Câu 12:
string [] str12 = {"aPPLE", "bRaNcH","AbAcUs","CLOvEr","BIUeBeRrY","cHeRry"};
var q12 = str12.OrderBy(n => n.ToUpper().ElementAt(0));
q12.Dump();
//Câu 13:
string[] str13= {"zero","one","two", "three", "four","five","six", "sevent", "eight", "night"};
var q13 = str13.OrderBy(n => n.ElementAt(0)).ThenByDescending(n => n.Count());
q13.Dump();
//Câu 14: fail
string [] str14 = {"from ", " salt", " earn "," last "," near" ," form "};
var q14 =  str14.GroupBy( n => {
var tong = 0;
foreach(char c in n.Trim()){
 //Console.WriteLine(System.Convert.ToInt32(c));
 int unicode = c;
 tong = tong + unicode;
 //Console.WriteLine(unicode);
}
return tong > 0;
});
q14.Dump();
//Câu 15: 
HocSinhs.Select( i => new {i.TenHocSinh, i.NamSinh}).GroupBy( i=> i.NamSinh)



